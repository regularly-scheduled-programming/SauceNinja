using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WingSpawner : MonoBehaviour
{
[SerializeField]
private GameObject[] chickenPrefabs;

[SerializeField]
private float spawnInterval, objectMinX, objectMaxX,objectY;




    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObject",this.spawnInterval, this.spawnInterval); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void spawnObject(){

        GameObject wingToSpawn=chickenPrefabs[Random.Range(0,chickenPrefabs.Length)];
        GameObject newWing= Instantiate(wingToSpawn);
        newWing.transform.position = new Vector2(Random.Range(this.objectMinX,this.objectMaxX),this.objectY);
    }
}
