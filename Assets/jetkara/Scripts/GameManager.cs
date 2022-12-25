using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Obstacle_prefb;

    public TextMesh scoreLabel;

    public static int score;

    public static float clock;
    public TextMesh clockLabel;

    private float counter = 1f;
    private double bottomPillarY = -2;
    private double topPillarY = 2;
    private float pillarDistance = 15.5f;

    public int Score
    {
        set
        {
            score = value;

            scoreLabel.text = Score.ToString();
        }
        get
        {
            return score;
        }
    }

    public float Clock
    {
        set
        {
            clock = value;

            clockLabel.text = Clock.ToString();
        }
        get
        {
            return clock;
        }
    }


    void Start()
    {
        score = 0;
        clock = 0;

        InvokeRepeating("CreateObjects", 1, 2);
    }

    void CreateObjects()
    {
        // https://answers.unity.com/questions/1397022/how-to-make-randomrange-step-by-a-certain-amount.html
        Instantiate(Obstacle_prefb, new Vector3((Mathf.Floor(Random.Range(7.5f, 15.5f) / 2f)) * 1.2f, Random.Range(-2f, 2f), 0), Quaternion.identity);
        counter += 1;
        Debug.Log(counter);
        // counter += Random.Range(2f, 4f);
        // pillarDistance -= counter;

        // Debug.Log(counter);

        // if (counter >= 5)
        // {
        //     counter = 0;
        //     pillarDistance = 15.5f;
        // }
    }
}
