using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeUI : MonoBehaviour
{
    [SerializeField]
    private GameObject[] lifePoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateLifeCounter(int lives) {
        switch (lives){

            case 4:
                lifePoints[4].SetActive(false);
                break;

           case 3:
                lifePoints[3].SetActive(false);
                break;

            case 2:
                lifePoints[2].SetActive(false);
                break;

            case 1:
                lifePoints[1].SetActive(false);
                break;

            case 0:
                lifePoints[0].SetActive(false);
                break;



        }

        
        
    }
}
