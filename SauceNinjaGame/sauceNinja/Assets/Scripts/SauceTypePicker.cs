using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SauceTypePicker :  WingType
{
    public sauceType currentSauce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PickSauce(int sauceChoice)
    {
        switch(sauceChoice)
        {
            case 1:
            currentSauce = sauceType.HoneyGarlic;
            break;
            case 2:
            currentSauce = sauceType.BBQ;
            break;
            case 3:
            currentSauce = sauceType.Buffalo;
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
