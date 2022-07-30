using System;
using SOScripts;
using TMPro;
using Units.Base;
using UnityEngine;
using UnityEngine.UI;


namespace InformationPanel
{
    public class InfoPanelModel
    {
        private BaseUnit _selectedBaseUnit;
        public BaseUnit SelectedBaseUnit
        {
            set
            {
                if (!Equals(_selectedBaseUnit, value))
                {
                    _selectedBaseUnit = value;
                    OnBaseUnitChanged?.Invoke(_selectedBaseUnit);
                }
            }
        }

        
        public event Action<BaseUnit> OnBaseUnitChanged;
        
        
        
        
        
        
        
        
        
        // private InformationPanelData panelData;
    
        // public InformationPanelData ProcessInformationPanelData(BaseUnitData bd)
        // {
        //     panelData.dataType = bd.GetType();
        //     
        //     panelData.UnitSprite = bd.unitSprite;
        //     panelData.UnitText = bd.unitName;
        //
        //     if (bd.GetType() == typeof(ProducerData))
        //     {
        //         panelData.ProductionText = ((ProducerData)bd).forcesToProduce.baseUnitData.unitName;
        //         panelData.ProductionButtonImage = ((ProducerData)bd).forcesToProduce.baseUnitData.unitSprite;
        //     }
        //     
        //     
        //     return panelData;
        // }
    }


    // public struct InformationPanelData
    // {
    //     public Type dataType;
    //     
    //     public Sprite UnitSprite;
    //     public string UnitText;
    //
    //     public string ProductionText;
    //     public Sprite ProductionButtonImage;
    // }
}