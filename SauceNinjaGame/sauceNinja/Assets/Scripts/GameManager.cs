using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int CurrentRound = 0;
    public RoundSettings[] RoundSettings;
    [Header("GameVariables")]
    [Space(15)]
    public int Lives;
    [SerializeField]
    private GameObject uiMaster;
    [SerializeField]
    const int DefaultLives = 5;
    [SerializeField]
    private WingSpawner spawner;
    private ScoreController SC;
    [SerializeField]
    private GameObject nextRoundUI;
    [SerializeField]
    private GameObject LooseUI;



    // Start is called before the first frame update
    void Start()
    {
        Lives = DefaultLives;
        SC = GetComponent<ScoreController>();
        StartNewRound();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeLifeAway()
    {
        --Lives;
        uiMaster.GetComponent<LifeUI>().updateLifeCounter(Lives);
        if (Lives < 1)
        {
            spawner.PauseSpawner();
            LooseUI.SetActive(true);
            //Game Over
        }
    }

    public void StartNewRound()
    {
        if (SC.Score > 0)
        {
            CurrentRound++;

        }
        uiMaster.GetComponent<GoalProgress>().SetupProgress(RoundSettings[CurrentRound].scoreRequired, SC.Score);
        nextRoundUI.SetActive(false);
        spawner.SetRoundSettings(RoundSettings[CurrentRound]);
        SC.UpdateGoal(RoundSettings[CurrentRound].scoreRequired);

    }

    public void RoundComplete()
    {
        spawner.PauseSpawner();
        nextRoundUI.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
