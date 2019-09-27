using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffSauce : MonoBehaviour
{
    public GameObject brush;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseOver()
    {
        brush.GetComponent<SauceBrush>().StopSaucing();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
