using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WingSpawner : MonoBehaviour
{
[SerializeField]
private GameObject[] chickenPrefabs;
private int ChickensAllowed =2;

[SerializeField]
private float  objectMinX, objectMaxX,objectY;

[SerializeField]
private float MinSpawnInterval, MaxSpawnInterval;

bool Paused=false;



    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            InvokeRepeating("spawnObject",Random.Range(MinSpawnInterval,MaxSpawnInterval), this.MaxSpawnInterval);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRoundSettings(RoundSettings Settings)
    {
        Paused = false;
        ChickensAllowed = Settings.ChickenTypes;
        MinSpawnInterval = Settings.SpawnIntervalMin;
        MaxSpawnInterval = Settings.SpawnIntervalMax;
        StartCoroutine(SpawnDelay(Random.Range(MinSpawnInterval, MaxSpawnInterval)));
    }


    private void spawnObject(){
        
        GameObject wingToSpawn=chickenPrefabs[Random.Range(0,ChickensAllowed)];
        GameObject newWing= Instantiate(wingToSpawn);
        newWing.transform.position = new Vector2(Random.Range(this.objectMinX,this.objectMaxX),this.objectY);
        StartCoroutine(SpawnDelay(Random.Range(MinSpawnInterval, MaxSpawnInterval)));
    }

    public void PauseSpawner()
    {
        Paused = true;
        //StopCoroutine(SpawnDelay(0));
        Destroy(FindObjectOfType<MoveChicken>().gameObject); 
    }
    IEnumerator SpawnDelay(float SpawnDelay)
    {
        yield return new WaitForSeconds(SpawnDelay);
        if(!Paused){

            spawnObject();
        }
        
    }

   
}
