using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    private int Playerscore = 0;
    // Update is called once per frame
    void Update()
    {
        // open door when score = 20 or more
        if (Playerscore >= 20)
        {
            this.gameObject.SetActive(false);
        }

               
    }

    // pull score from other script
    public void UpdateScore(int score)
    {
        Playerscore = score;
    }
}
