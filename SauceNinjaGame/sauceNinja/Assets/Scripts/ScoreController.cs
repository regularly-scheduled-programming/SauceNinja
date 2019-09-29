using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{

    [SerializeField] public TextMeshProUGUI ScoreText;
    [SerializeField] public TextMeshProUGUI GoalText;
    [SerializeField] public int Score;
    public int Goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "SCORE: " +Score;
    }

    public void UpdateGoal(int goal)
    {
        Goal = goal;
        GoalText.text = "GOAL: " + goal;
    }

    public void CheckScore()
    {
        if (Score >= Goal)
        {
            GetComponent<GameManager>().RoundComplete();
        }
    }
}
