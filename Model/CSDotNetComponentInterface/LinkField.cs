﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Collections.Specialized;

using CSGeneral;

/// <summary>
/// Represents a [Link]. Main responsability is to 
/// resolve the linkages at runtime of a simulation.
/// Links can be to APSIM components (which are by default matched using type only) or
/// they can be links to Instance objects (which are by default matched using type ane name).
/// e.g. 
///    APSIM linkages:
///    [Link] Paddock MyPaddock;                      // links to the current paddock.
///    [Link] Component MyComponent;                  // links to the current component.
///    [Link] SoilWat MySoil;                         // links to the component in scope that has the type 'SoilWat'
///    [Link("wheat2")] Wheat W;                      // links to the sibling component named 'wheat2'
/// !!!!!!!!!   [Link(".simulation.paddock1.wheat2")] Wheat W; // links to a specific component with the full path '.simulation.paddock1.wheat2'
/// e.g. 
///    Instance linkages (cannot specify a link path for instance linkages):
///    [Link] Function ThermalTime;        // links to an object with type Function and name ThermalTime
///    [Link] Leaf Leaf;                   // links to an object with type Leaf and name Leaf
/// <summary>
public class LinkField
{
    private FieldInfo Field;
    private Link LinkAttr;
    private Instance In;
    ApsimComponent Comp;
    #region private
    private static StringBuilder Data = new StringBuilder(10000);
    #endregion
    #region public
    //----------------------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    /// <param name="_In"></param>
    /// <param name="_Field"></param>
    /// <param name="_LinkAttr"></param>
    //----------------------------------------------------------------------
    public LinkField(Instance _In, FieldInfo _Field, Link _LinkAttr)
    {
        In = _In;
        Field = _Field;
        LinkAttr = _LinkAttr;
        Comp = In.ParentComponent();
    }
    /// <summary>
    /// Creates any classes that are of type [Link] in the model
    /// </summary>
    public void Resolve()
    {
        if (Field.GetValue(In) == null)
        {
            Object ReferencedObject = null;

            // Load in the probe info assembly.
            Assembly ProbeInfo = Types.GetProbeInfoAssembly();

            String TypeToFind = Field.FieldType.Name;
            String NameToFind = Field.Name;

            if (IsAPSIMType(TypeToFind))
            {
                if (LinkAttr._Path == null)
                    NameToFind = null; // default is not to use name.
                else
                {
                    NameToFind = LinkAttr._Path;
                }
                if (NameToFind != null && NameToFind.Contains("."))
                    ReferencedObject = GetSpecificApsimComponent(NameToFind);
                else
                    ReferencedObject = FindApsimComponent(NameToFind, TypeToFind);
            }
            else
            {
                // Link is an Instance link - use name and type to find the object.
                ReferencedObject = FindInstanceObject(NameToFind, TypeToFind);
            }

            // Set the value of the [Link] field to the newly created object.
            if (ReferencedObject == null)
            {
                if (LinkAttr._IsOptional != IsOptional.Yes)
                    throw new Exception("Cannot find [Link] for type: " + TypeToFind + " " + NameToFind + " in object: " + In.Name);
            }
            else
                Field.SetValue(In, ReferencedObject);
        }

    }
    #endregion
    //----------------------------------------------------------------------
    /// <summary>
    /// Search for an Instance object in scope that has the specified name and type.
    /// Returns null if not found.
    /// </summary>
    //----------------------------------------------------------------------
    private Object FindInstanceObject(String NameToFind, String TypeToFind)
    {
        // Check our children first.
        foreach (NamedItem Child in In.Children)
        {
            if (NameToFind == Child.Name && Utility.IsOfType(Child.GetType(), TypeToFind))
                return Child;
        }

        // Check our siblings, our parent's siblings and our parent's, parent's siblings etc.
        Instance Parent = In.Parent;
        while (Parent != null)
        {
            if (Parent.Name == TypeToFind)
                return Parent;
            foreach (NamedItem Sibling in Parent.Children)
            {
                if (NameToFind == Sibling.Name && Utility.IsOfType(Sibling.GetType(), TypeToFind))
                    return Sibling;
            }
            Parent = Parent.Parent;
        }
        return null;
    }

    #region protected
    //----------------------------------------------------------------------
    /// <summary>
    /// Returns true if the specified typename is an APSIM type.
    /// </summary>
    //----------------------------------------------------------------------
    protected bool IsAPSIMType(String TypeToFind)
    {
        if (TypeToFind == "Paddock" || TypeToFind == "Component")
            return true;
        else
            return Types.GetProbeInfoAssembly().GetType("ModelFramework." + TypeToFind) != null;    //??????
    }
    //----------------------------------------------------------------------
    /// <summary>
    /// Create a DotNetProxy class to represent an Apsim component.
    /// </summary>
    //----------------------------------------------------------------------
    protected Object CreateDotNetProxy(String TypeToFind, String FQN)
    {
        Type ProxyType;
        if (TypeToFind == "Paddock" || TypeToFind == "Component")
            ProxyType = Assembly.GetExecutingAssembly().GetType(TypeToFind);
        else
            ProxyType = Types.GetProbeInfoAssembly().GetType("ModelFramework." + TypeToFind);

        if (ProxyType == null)
            throw new Exception("Cannot find proxy reference: " + TypeToFind);
        Object[] Parameters = new Object[2];
        Parameters[0] = FQN;
        Parameters[1] = Comp;
        return Activator.CreateInstance(ProxyType, Parameters);
    }
    /// <summary>
    /// Go find an Apsim component IN SCOPE that matches the specified name and type.
    /// IN SCOPE means a component that is a sibling or in the paddock
    /// above.
    /// </summary>
    protected Object FindApsimComponent(String NameToFind, String TypeToFind)
    {
        String OurName = Comp.GetName();
        String PaddockName = OurName.Substring(0, OurName.LastIndexOf('.'));

        if (TypeToFind == "Paddock")
            return CreateDotNetProxy(TypeToFind, PaddockName);
        if (TypeToFind == "Component" && NameToFind == null)
            return CreateDotNetProxy(TypeToFind, OurName);

        while (PaddockName != "")
        {
            // Get a list of all paddock children.
            foreach (KeyValuePair<uint, String> pair in Comp.SiblingComponents)
            {
                //////////////// need to find out how to do this           getComponentType(pair.Value, Data);
                String SiblingType = Data.ToString();

                if (SiblingType.ToLower() == TypeToFind.ToLower())
                {
                    String SiblingShortName = pair.Value.Substring(pair.Value.LastIndexOf('.') + 1);
                    if (NameToFind == null || NameToFind == SiblingShortName)
                        return CreateDotNetProxy(TypeToFind, pair.Value);
                }
            }
            // Go to parent paddock.
            //////not sure I can do this yet   PaddockName = PaddockName.Substring(0, PaddockName.LastIndexOf('.'));
        }

        // If we get this far then we didn't find the APSIM component.
        return null;
    }
    //----------------------------------------------------------------------
    /// <summary>
    /// Go find a component with the specified name. NameToFind can be either
    /// a relative or absolute address.
    /// </summary>
    //----------------------------------------------------------------------
    protected Object GetSpecificApsimComponent(String NameToFind)
    {
        if (NameToFind.Contains(".MasterPM."))
            return CreateDotNetProxy(NameToFind, NameToFind);   // absolute reference.
        else
        {
            // relative reference.
            String OurName = Comp.GetName();
            String ParentName = "";
            int PosLastPeriod = OurName.LastIndexOf('.');
            if (PosLastPeriod == -1)
                throw new Exception("Invalid component name found: " + OurName);
            ParentName = OurName.Substring(0, PosLastPeriod);
            return CreateDotNetProxy(NameToFind, ParentName + "." + NameToFind);
        }
    }
    #endregion
}






 
