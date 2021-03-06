﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Reflection;
using CSGeneral;
using System.Data;
using ModelFramework;
using EBMath;


//FIXME  This class finds this ambigious.  [Description("Evaluate a mathematical expression using the EvaluateExpression dll. Obs: Expression can contain variable names from Plant2")]
public class ExpressionFunction : Function
{
    [Param]
    private string Expression = "";

    private ExpressionEvaluator fn = new ExpressionEvaluator();
    private bool parsed = false;

    [Output]
    public override double Value
    {
        get
        {
            if (!parsed)
            {
                Parse(fn, Expression);
                parsed = true;
            }
            FillVariableNames(fn, My);
            Evaluate(fn);
            return fn.Result;
        }
    }

    private static void Parse(ExpressionEvaluator fn, string ExpressionProperty)
    {
        fn.Parse(ExpressionProperty.Trim());
        fn.Infix2Postfix();
    }

    private static void FillVariableNames(ExpressionEvaluator fn, ModelFramework.Component RelativeTo)
    {
        ArrayList varUnfilled = fn.Variables;
        ArrayList varFilled = new ArrayList();
        Symbol symFilled;
        foreach (Symbol sym in varUnfilled)
        {
            symFilled.m_name = sym.m_name;
            symFilled.m_type = EBMath.Type.Variable;
            symFilled.m_valueString = "";
            symFilled.m_value = 0;
            if (!RelativeTo.Get(sym.m_name.Trim(), out symFilled.m_value))
                throw new Exception("Cannot find variable: " + sym.m_name + " in function: " + RelativeTo.Name);
            varFilled.Add(symFilled);
        }
        fn.Variables = varFilled;
    }

    private static void Evaluate(ExpressionEvaluator fn)
    {
        fn.EvaluatePostfix();
        if (fn.Error)
        {
            throw new Exception(fn.ErrorDescription);
        }
    }

    /// <summary>
    /// Return the value of the specified property as an object. The PropertyName
    /// is relative to the RelativeTo argument (usually Plant).
    /// Format:
    ///    [function(]VariableName[)]
    /// Where:
    ///     function is optional and can be one of Sum, subtract, multiply, divide, max, min
    ///     VariableName is the name of a Plant variable. It can also include an array. Array can
    ///                  have a filter inside of square brackets. Filter can be an array index (0 based)
    ///                  or be the name of a class or base class.
    /// e.g. Leaf.MinT
    ///      sum(Leaf.Leaves[].Live.Wt)              - sums all live weights of all objects in leaves array.
    ///      subtract(Leaf.Leaves[].Live.Wt)         - subtracts all live weights of all objects in leaves array.
    ///      Leaf.Leaves[1].Live.Wt                  - returns the live weight of the 2nd element of the leaves array.
    ///      sum(Leaf.Leaves[AboveGround].Live.Wt)   - returns the live weight of the 2nd element of the leaves array.
    /// </summary>
    public static object Evaluate(string Expression, ModelFramework.Component RelativeTo)
    {
        ExpressionEvaluator fn = new ExpressionEvaluator();
        Parse(fn, Expression);
        FillVariableNames(fn, RelativeTo);
        Evaluate(fn);
        if (fn.Results != null)
            return fn.Results;
        else
            return fn.Result;
    }

}



