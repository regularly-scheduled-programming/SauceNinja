using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WingSpawner : MonoBehaviour
{
    [SerializeField]
private GameObject chickenPrefab;
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
    GameObject newWing= Instantiate(this.chickenPrefab);
    newWing.transform.position = new Vector2(Random.Range(this.objectMinX,this.objectMaxX),this.objectY);
    }
}
