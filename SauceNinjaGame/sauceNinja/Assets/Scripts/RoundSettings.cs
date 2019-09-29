using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RoundSettings 
{
    public int scoreRequired;

    [Range(1,3)]
    public int ChickenTypes;

    //[Range(1,5)]
   // public int SpawnerAmount;

    [Range(.7f, 3)]
    public float SpawnIntervalMin;

    [Range(.7f,5)]
    public float SpawnIntervalMax;

}
