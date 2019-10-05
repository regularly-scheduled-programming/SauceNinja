using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingSpritePicker : MonoBehaviour
{
    [SerializeField]
    Sprite[] WingSprites;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = WingSprites[Random.Range(0, WingSprites.Length)]; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
