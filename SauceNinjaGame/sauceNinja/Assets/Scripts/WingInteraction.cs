using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingInteraction : MonoBehaviour
{
    [SerializeField]
    WingType.sauceType CurrentSauce;
    [SerializeField]
    GameObject ScorePopup;
    [SerializeField]
    GameObject NegativePopup;
    private Rigidbody2D RB;
    private Animator AC;
    [SerializeField]
    float DestroyDelay=1f;
    private SpriteRenderer wingSprite;
    [SerializeField]
    private Color BadWing;

    // Start is called before the first frame update

    public void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        AC =ScorePopup.GetComponent<Animator>();
        wingSprite = GetComponent<SpriteRenderer>();
    }



    public bool Sauced(WingType.sauceType brush)
    {
        bool result;
        if (brush == CurrentSauce)
        {
            result = true;
            RB.simulated = false;
            ScorePopup.SetActive (true);
            AC.SetBool("Spawned", true);
            StartCoroutine(DestroyWing(DestroyDelay));
            

            //Put anything that happens to the wing when score
        }

        else {
            //Handheld.Vibrate();
            result = false;
            FindObjectOfType<GameManager>().TakeLifeAway();
            RB.simulated = false;
            wingSprite.color = BadWing;
            NegativePopup.SetActive(true);
            StartCoroutine(DestroyWing(DestroyDelay));
            //put anything that happens to wing when it's the wrong sauce

        }


       return (result);
    }


    IEnumerator DestroyWing(float delayAmount)
    {
        yield return new WaitForSeconds(delayAmount);
        Destroy(gameObject);

    }
}
