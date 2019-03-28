using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoredisplay : MonoBehaviour
{
    private int Playerscore = 0;
    public Text Scoretext;

    void Update()
    {
        Scoretext.text = Playerscore.ToString();
    }

    public void UpdateScore(int score)
    {
        Playerscore = score;
    }
}
