using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SauceWing : MonoBehaviour {

public ScoreController SC;
public GameObject SauceBrush;

void Start()
    {
        SC = GameObject.FindObjectOfType<ScoreController>();
        SauceBrush = GameObject.FindObjectOfType<SauceBrush>().gameObject;
    }

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Cut")
        {

            if( this.GetComponent<WingInteraction>().Sauced(SauceBrush.GetComponent<SauceTypePicker>().currentSauce))
            {
                SC.Score+=25;
                SC.CheckScore();
                //Destroy (this.gameObject);
            }
            else
            {
                SauceBrush.GetComponent<SauceTypePicker>().currentSauce = WingType.sauceType.NONE;
                SauceBrush.GetComponent<SauceBrush>().StopSaucing();
              //  Destroy (this.gameObject);
            }

		   
           
		}
	}
}
