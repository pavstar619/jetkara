using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour
{
    public AudioClip[] auClip;
    void Start()
    {
        GetComponent<AudioSource>().clip = auClip[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            GetComponent<AudioSource>().Play();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}
