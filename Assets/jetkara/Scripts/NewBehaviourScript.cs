using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("start function call");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update function call");
    }

    void Awake()
    {
        Debug.Log("awake function call");
    }
}
