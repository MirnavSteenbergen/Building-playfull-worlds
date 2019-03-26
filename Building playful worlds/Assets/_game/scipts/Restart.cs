using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            RestartGame();
        }
    }
    public void RestartGame()
    {
        Debug.Log("We zijn er!");
        SceneManager.LoadScene(0);
    }
}
