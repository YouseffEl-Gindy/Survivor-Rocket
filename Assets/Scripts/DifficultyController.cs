using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyController : MonoBehaviour
{

    public static DifficultyController Instance;

    //Interval for score incrementation
    [SerializeField] int scoreInterval;

    public GameObject Rock1;
    public GameObject Rock2;
    public GameObject Rock3;
    public GameObject Rock4;

    bool incremented;

    [SerializeField] float prizeValue;

    private void Awake()
    {
        if(Instance != null) Destroy(gameObject);
        else Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int Score = (int)ScoreManger.Instance.GetScore();
        if (Score % scoreInterval == 0 && Score != 0 && !incremented)
        {
            
            Rock1.GetComponent<MovingRock>().IncremntSpeed(1);
            Rock2.GetComponent<MovingRock>().IncremntSpeed(1);
            Rock3.GetComponent<MovingRock>().IncremntSpeed(1);
            Rock4.GetComponent<MovingRock>().IncremntSpeed(1);

            ViewController.Instance.IncrementSpeedOfRocks(1);

            incremented = true;

        }
        else if (Score % 10 != 0)
        {
            incremented = false;
        }
    }
    public void CollectPrize()
    {
        Rock1.GetComponent<MovingRock>().IncremntSpeed(prizeValue);
        Rock2.GetComponent<MovingRock>().IncremntSpeed(prizeValue);
        Rock3.GetComponent<MovingRock>().IncremntSpeed(prizeValue);
        Rock4.GetComponent<MovingRock>().IncremntSpeed(prizeValue);
    }
}
