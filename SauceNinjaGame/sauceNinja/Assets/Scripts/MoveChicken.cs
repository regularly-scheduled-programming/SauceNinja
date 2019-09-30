﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MoveChicken : MonoBehaviour
{
    [SerializeField]
    private float minXSpeed,maxXSpeed,minYSpeed,maxYSpeed;

    [SerializeField]
    private float destroyTime;
    

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
        Destroy(this.gameObject, this.destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.1f)
        {
            if(SceneManager.GetActiveScene().buildIndex==1)
            {
            FindObjectOfType<GameManager>().TakeLifeAway();
            }
            Destroy(gameObject);
        }
    }
}
