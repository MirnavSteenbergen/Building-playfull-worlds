using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPdisplay : MonoBehaviour
{
    private int PlayerHP = 0;
    public Text HPtext;

    //turn int into string
    void Update()
    {
        HPtext.text = PlayerHP.ToString();
    }

    public void UpdateHP(int CurrentHP)
    {
        PlayerHP = CurrentHP;
    }
}
