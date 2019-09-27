using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingInteraction : MonoBehaviour
{
    [SerializeField]
    WingType.sauceType CurrentSauce;
    // Start is called before the first frame update
   
    public bool Sauced(WingType.sauceType brush)
    {
        bool result;
        if (brush == CurrentSauce)
        {
            result = true;
            //Put anything that happens to the wing when score
        }

        else {
            result = false;
            FindObjectOfType<GameManager>().TakeLifeAway();
            //put anything that happens to wing when it's the wrong sauce
        }


       return (result);
    }
}
