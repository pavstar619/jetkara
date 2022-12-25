using UnityEngine;


public class ObjectMove : MonoBehaviour
{
    private double speed = 0.04;
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - (float)speed, transform.position.y, 0);
        // Debug.Log(transform.position);
        if (transform.position.x <= -7.5f)
        {
            Destroy(gameObject);
        }
        // speed += 0.01;
        // Debug.Log("Speed increased" + speed);
    }
}
