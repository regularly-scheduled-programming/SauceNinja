﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatanaManager : MonoBehaviour
{
    public GameObject[] KatanaSprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOffAllKatanas()
    {
        for (int i = 0; i < 3; i++)
        {
            KatanaSprites[i].SetActive(false);
        }
    }
}
