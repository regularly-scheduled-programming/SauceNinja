using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalProgress : MonoBehaviour
{
    public GameObject ProgressBar;
    [SerializeField]
    private GameObject ProgressHandle;
    private float StartingScore;
    private float ActualGoal;
    private float LerpA;
    private float LerpB;
    private float LerpingTime;

    [SerializeField]
    private bool Lerping=false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetupProgress(float goal, float CurrentScore)
    {
        StartingScore = CurrentScore;
        ActualGoal = goal - CurrentScore;

        ProgressBar.GetComponent<Slider>().value = 0;


    }
    //STEP 1 Updates the information need to lerp the progress bar
    public void UpdateProgress(float PlayerScore)
    {
        
        float pointsearned = PlayerScore - StartingScore;
        //float ProgressPercent = pointsearned / ActualGoal;
        LerpB = pointsearned / ActualGoal;
        if (Lerping == false)
        {
            LerpA = ProgressBar.GetComponent<Slider>().value;
            StartCoroutine(MoveProgressBar());
    
        }
        
        
        //ProgressBar.GetComponent<Slider>().value = ProgressPercent;


    }

    //STEP 3 Function that actualy move the progress bar
    public void LerpBar()
    {
        //Change this value to tweak how fast the lerp is
        float OverallLerpTime = .35f;
        LerpingTime += Time.deltaTime;
        if (LerpingTime > OverallLerpTime)
        {
            LerpingTime = OverallLerpTime;
        }
        float LerpPerc = LerpingTime / OverallLerpTime;
        ProgressBar.GetComponent<Slider>().value = Mathf.Lerp(LerpA, LerpB, LerpPerc);
        
    }
    
    //STEP 2Coroutine that handles iteration of the lerp
    IEnumerator MoveProgressBar()
    {
        //ProgressHandle.SetActive(true);
        LerpingTime = 0;
        Lerping = true;
        while (ProgressBar.GetComponent<Slider>().value < LerpB)
        {
            LerpBar();
            yield return new WaitForFixedUpdate();
        }
        Lerping = false;
        //ProgressHandle.SetActive(false);
        StopAllCoroutines();
    }

}
