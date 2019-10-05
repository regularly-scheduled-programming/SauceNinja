using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;

public class SauceTypePicker :  WingType
{
    public sauceType currentBrushSauce;
    

    public GameObject sauceButton1;
  
   
    public GameObject sauceButton2;
  

    public GameObject sauceButton3;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PickSauce(int sauceChoice)
    {
        switch(sauceChoice)
        {
             case 0:
            currentBrushSauce = sauceType.NONE;
         
            break;

            case 1:
            currentBrushSauce = sauceType.HoneyGarlic;
           
            break;

            case 2:
            currentBrushSauce = sauceType.BBQ;
            
            break;

            case 3:
            currentBrushSauce = sauceType.Buffalo;
           
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
