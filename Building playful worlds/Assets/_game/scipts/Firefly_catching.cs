using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firefly_catching : MonoBehaviour
{
    public int score;
    public int scorevalue = 1;
    public GameObject ScoredisplayUI;
    public GameObject Gameoverscreen;

    // Set Score to 0 at start
    void Start()
    {
        score = 0;
    }

    
    // Check if the collision is with a firefly and add score
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Firefly")
        {
            score += scorevalue;
            ScoredisplayUI.GetComponent<Scoredisplay>().UpdateScore(score);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("we are counting");
            score += scorevalue;
            ScoredisplayUI.GetComponent<Scoredisplay>().UpdateScore(score);
        }
    }
}
