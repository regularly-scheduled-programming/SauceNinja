using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Lives;
    [SerializeField]
    private GameObject uiMaster;

    [SerializeField]
    const int DefaultLives=5;
    // Start is called before the first frame update
    void Start()
    {
        Lives = DefaultLives;
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
            //Game Over
        }
    }

    public void AddScore()
    {

    }
}
