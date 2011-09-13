﻿using System;
using System.Collections.Generic;
using System.Text;

public partial class SurfaceOrganicMatter : Instance
{

    [EventHandler]
    public void OnTick(TimeType tick)
    {
        if (initialised)
            surfaceOM_ONtick();
    }
    bool initialised = false;

    [EventHandler]
    public void OnTillage(TillageType data)
    {
        surfom_tillage(data);
    }

    [EventHandler]
    public void OnTillage_single(Tillage_singleType data)
    {
        surfom_tillage_single(data);
    }

    [EventHandler]
    public void OnAdd_surfaceom(Add_surfaceomType data)
    {
        surfom_add_surfom(data);
    }
    
    [EventHandler]
    public void OnInit2() { OnReset(); }
    
    [EventHandler]
    public void OnReset() { initialised = true; surfom_Reset(); }
    
    [EventHandler]
    public void OnCreate() { }
    
    [EventHandler]
    public void OnSum_report() { surfom_Sum_Report(); }

    [EventHandler]
    public void OnRemove_surfaceOM(SurfaceOrganicMatterType SOM) { surfom_remove_surfom(SOM); }

    [EventHandler]
    public void OnNewmet(NewMetType newmetdata) { g.MetData = newmetdata; }
   
    [EventHandler]
    public void OnIrrigated(IrrigationApplicationType data) { surfom_ONirrigated(data); }

    [EventHandler]
    public void OnCrop_chopped(CropChoppedType data) { surfom_ON_Crop_chopped(data); }

    [EventHandler]
    public void OnBiomassRemoved(BiomassRemovedType BiomassRemoved) { SurfOMOnBiomassRemoved(BiomassRemoved); }
    
    [EventHandler]
    public void OnProcess()
    {
        surfom_get_other_variables();
        surfom_Process();
        //catch (Exception e) { }

        if (Today.DayOfYear == 300)
            return;
    }
   
    [EventHandler]
    public void OnPost() { }

    [EventHandler]
    public void OnActualresiduedecompositioncalculated(SurfaceOrganicMatterDecompType SOMDecomp) { surfom_decompose_surfom(SOMDecomp); }

    [EventHandler]
    public void OnProp_up(Prop_upType data) { surfom_prop_up(data); }

   
}

