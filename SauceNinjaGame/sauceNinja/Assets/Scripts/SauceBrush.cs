using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SauceBrush : MonoBehaviour {

	public GameObject SaucePrefab;
	public float minVelocity = .001f;

	bool isSaucing = false;

	Vector2 previousPos;

	GameObject currentSauceTrail;

	Rigidbody2D myBody;
	Camera cam;
	CircleCollider2D circleCollider;

    public bool isUsingMouse;

	void Start ()
	{
		cam = Camera.main;
		myBody = GetComponent<Rigidbody2D>();
		circleCollider = GetComponent<CircleCollider2D>();
	}

	// Update is called once per frame
	void Update () {

        //MOUSE
        if(isUsingMouse)
        {
            if (Input.GetMouseButtonDown(0))
            {
                StartSaucing();
            }
            else if (Input.GetMouseButtonUp(0))
            {
                StopSaucing();
            }
            
           
        
        }
        else//TOUCHSCREEN
        {
             if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                switch(touch.phase)
                {
                    case TouchPhase.Began:
                    break;

                    case TouchPhase.Moved:
                     StartSaucing();
                    break;

                    case TouchPhase.Stationary:
                    StopSaucing();
                    break;

                    case TouchPhase.Ended:
                     StopSaucing();
                    break;
                }
               
            }
            else if (Input.touchCount == 0)
            {
                StopSaucing();
            }
        }

		if (isSaucing)
		{
			UpdateSauce();
		}

	}

	void UpdateSauce ()
	{
        if(isUsingMouse)//MOUSE
        {
            
            Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
            myBody.position = newPosition;

            float velocity = (newPosition - previousPos).magnitude * Time.deltaTime;
            if (velocity > minVelocity)
            {
                circleCollider.enabled = true;
               SaucePrefab.SetActive(true);
                
            } else
            {
                circleCollider.enabled = false;
                 SaucePrefab.SetActive(false);
            }

            previousPos = newPosition;
           
        }
        else//TOUCHSCREEN
        {
            Touch touch = Input.GetTouch(0);
            Vector2 newPosition = cam.ScreenToWorldPoint(touch.position);
            myBody.position = newPosition;

            float velocity = (newPosition - previousPos).magnitude * Time.deltaTime;
            if (velocity > minVelocity)
            {
                circleCollider.enabled = true;
            } else
            {
                circleCollider.enabled = false;
            }

            previousPos = newPosition;
        }
	}

	void StartSaucing ()
	{
        if(isUsingMouse)//MOUSE
        {
           
            isSaucing = true;
            previousPos = cam.ScreenToWorldPoint(Input.mousePosition);
           // currentSauceTrail = Instantiate(SaucePrefab,transform);
            circleCollider.enabled = true;
        }
        else//TOUCHSCREEN
        {
            Touch touch = Input.GetTouch(0);
            isSaucing = true;
            //currentSauceTrail = Instantiate(SaucePrefab, transform);
            previousPos = cam.ScreenToWorldPoint(touch.position);
            circleCollider.enabled = true;
        }
    }

	public void StopSaucing ()
	{
        
		isSaucing = false;
       
        if(currentSauceTrail != null)
        {
           
        }
		
		//Destroy(currentSauceTrail);
        
		circleCollider.enabled = false;

	}

}