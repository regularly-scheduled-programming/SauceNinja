using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeUI : MonoBehaviour
{
    [SerializeField]
    private GameObject[] lifePoints;
    [SerializeField]
    private Sprite LostLifeSprite;
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
                lifePoints[4].GetComponent<Image>().sprite=LostLifeSprite;
                break;

           case 3:
                lifePoints[3].GetComponent<Image>().sprite = LostLifeSprite;
                break;

            case 2:
                lifePoints[2].GetComponent<Image>().sprite = LostLifeSprite;
                break;

            case 1:
                lifePoints[1].GetComponent<Image>().sprite = LostLifeSprite;
                break;

            case 0:
                lifePoints[0].GetComponent<Image>().sprite = LostLifeSprite;
                break;



        }

        
        
    }
}
