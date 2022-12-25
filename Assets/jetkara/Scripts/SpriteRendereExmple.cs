using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRendereExmple : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer spriteRendere;

    void Start()
    {
        
        spriteRendere = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //0->left click
        //1->right click
        //2->middle click
        if(Input.GetMouseButtonDown(0))
        {
            spriteRendere.flipY= true;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);

        }
        else if(Input.GetMouseButtonUp(0))
        {
            spriteRendere.flipY = false;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }


    
    void OnTriggerEnter2D(Collider2D col)
    {
       if(col.tag=="Finish")
        {
            Debug.Log("finish");
        }

        else if (col.tag == "Score")
        {
            Debug.Log("Score");
        }
    }

}
