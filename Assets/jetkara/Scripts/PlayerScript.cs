using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    bool dead;
    public AudioClip[] auClip;
    public GameObject fire;

    private SpriteRenderer spriteRendererObject;

    private Vector3 scaleChange;





    void Start()
    {
        dead = false;
        GetComponent<AudioSource>().clip = auClip[0];
        spriteRendererObject = this.GetComponent<SpriteRenderer>();
        scaleChange = new Vector3(-0.06f, -0.06f, 0f);

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !dead)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider == null)
            {
                spriteRendererObject.flipY = true;
                Jump();
            }
        }
        else if (Input.GetMouseButtonUp(0) && !dead)
        {
            spriteRendererObject.flipY = false;
        }
        // clock++;
        GameObject.FindObjectOfType<GameManager>().Clock++;
        // Debug.Log(clock);
    }

    void Jump()
    {
        fire.SetActive(true);
        GetComponent<AudioSource>().Play();

        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!dead)
        {
            if (col.tag == "Score")
            {
                GameObject.FindObjectOfType<GameManager>().Score++;

                // GetComponent<Transform>().localScale += scaleChange;

                // Destroy(col.gameObject);
            }
            else if (col.tag == "Finish")
            {
                Handheld.Vibrate();
                dead = true;
                spriteRendererObject.flipY = true;
                GetComponent<AudioSource>().clip = auClip[1];
                GetComponent<AudioSource>().Play();
                Invoke("BackToMain", 1.5f);
            }
        }
    }

    void BackToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
