using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoredisplay : MonoBehaviour
{
    private int Playerscore = 0;
    public Text Scoretext;
    public GameObject Winscreen;

    void Update()
    {
        Scoretext.text = Playerscore.ToString();

        if (Playerscore >= 50)
        {
            Win();
        }
    }

    // pull score from script: Firefly_catching
    public void UpdateScore(int score)
    {
        Playerscore = score;
    }

    void Win()
    {
        Winscreen.SetActive(true);
    }
}
