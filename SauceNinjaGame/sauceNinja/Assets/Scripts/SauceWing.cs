using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SauceWing : MonoBehaviour {

public ScoreController SC;
void Start()
    {
        SC = GameObject.FindObjectOfType<ScoreController>();
    }

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Cut") {
            Debug.Log("fuck");
			Destroy (this.gameObject);
            SC.Score++;
		}
	}
}
