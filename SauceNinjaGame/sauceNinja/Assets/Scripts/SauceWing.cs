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

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Cut"&&collision.gameObject.transform.position.y>-2.48f)
        {

            if( this.GetComponent<WingInteraction>().Sauced(SauceBrush.GetComponent<SauceTypePicker>().currentBrushSauce))
            {
                SC.Score+=25;
                SC.CheckScore();
                //Destroy (this.gameObject);
            }
            else
            {
                SauceBrush.GetComponent<SauceTypePicker>().PickSauce(0);
                SauceBrush.GetComponent<SauceBrush>().StopSaucing();
                FindObjectOfType<KatanaManager>().TurnOffAllKatanas();
              //  Destroy (this.gameObject);
            }

		   
           
		}
	}
}
