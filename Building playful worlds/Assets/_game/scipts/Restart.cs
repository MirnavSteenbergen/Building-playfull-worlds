using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{ //script is only active if player dies (check PlayerHP script)
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            RestartGame();
        }
    }
    public void RestartGame()
    {
        //Debug.Log("We zijn er!");
        SceneManager.LoadScene(0);
    }
}
