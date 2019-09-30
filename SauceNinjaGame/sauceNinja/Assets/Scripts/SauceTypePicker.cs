using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;

public class SauceTypePicker :  WingType
{
    public sauceType currentBrushSauce;
    

    public GameObject sauceButton1;
    public Color hg;
   
    public GameObject sauceButton2;
    public Color bbq;

    public GameObject sauceButton3;
    public Color buff;

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
            sauceButton1.GetComponent<Image>().color = hg;
            sauceButton2.GetComponent<Image>().color = bbq;
            sauceButton3.GetComponent<Image>().color = buff;
            break;

            case 1:
            currentBrushSauce = sauceType.HoneyGarlic;
            sauceButton1.GetComponent<Image>().color = Color.green;
            sauceButton2.GetComponent<Image>().color =bbq;
            sauceButton3.GetComponent<Image>().color = buff;
            break;

            case 2:
            currentBrushSauce = sauceType.BBQ;
            sauceButton1.GetComponent<Image>().color = hg;
            sauceButton2.GetComponent<Image>().color = Color.green;
            sauceButton3.GetComponent<Image>().color = buff;
            break;

            case 3:
            currentBrushSauce = sauceType.Buffalo;
            sauceButton1.GetComponent<Image>().color = hg;
            sauceButton2.GetComponent<Image>().color = bbq;
            sauceButton3.GetComponent<Image>().color = Color.green;
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
