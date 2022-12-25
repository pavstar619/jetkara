using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigidbody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
