using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject Obstacle_prefb;
    void Start()
    {
        
        InvokeRepeating("CreateObjects", 1, 2);
    }

    void CreateObjects()
    {
        Instantiate(Obstacle_prefb, new Vector3(7.5f, Random.Range(-2f, 2.1f) , 0) , Quaternion.identity);
    }

    
}
