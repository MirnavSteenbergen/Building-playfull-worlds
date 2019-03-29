using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firefly_catching : MonoBehaviour
{
    public int score;
    public int scorevalue = 1; // value that will count up when score is triggered
    public GameObject ScoredisplayUI;
    public GameObject Gameoverscreen;
    public GameObject Door;

    // Set Score to 0 at start
    void Start()
    {
        score = 0;
    }

    
    // Check if the collision is with a firefly and add score
    private void OnTriggerEnter(Collider other)
    {
        // if collision with firefly count score
        if (other.tag == "Firefly")
        {
            score += scorevalue;
            ScoredisplayUI.GetComponent<Scoredisplay>().UpdateScore(score);
            Door.GetComponent<door>().UpdateScore(score);
        }
    }

    /*// debug/cheat function
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("we are cheating");
            score += scorevalue;
            ScoredisplayUI.GetComponent<Scoredisplay>().UpdateScore(score);
            Door.GetComponent<door>().UpdateScore(score);
        }
    }*/
}
