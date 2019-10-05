using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalProgress : MonoBehaviour
{
    public GameObject ProgressBar;
    private float StartingScore;
    private float ActualGoal;


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

    public void UpdateProgress(float PlayerScore)
    {
        
        float pointsearned = PlayerScore - StartingScore;
        float ProgressPercent = pointsearned / ActualGoal;
        ProgressBar.GetComponent<Slider>().value = ProgressPercent;
        

    }
    
}
