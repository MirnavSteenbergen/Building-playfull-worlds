using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int HPmaxPlayer = 10;
    public int HPcurrentPlayer;
    public int weapondamageOnPlayer = 1;
    public int Potionheal = 5;
    public GameObject HPdisplayUI;
    public GameObject Gameoverscreen;

    // Start is called before the first frame update
    void Start()
    {
        HPcurrentPlayer = HPmaxPlayer;
        HPdisplayUI.GetComponent<HPdisplay>().UpdateHP(HPcurrentPlayer);
    }

    private void OnTriggerEnter(Collider other)
    { //player only loses HP when hit by enemy weapon
        if (other.tag == "weaponEnemy")
        {
            HPcurrentPlayer -= weapondamageOnPlayer;
            HPdisplayUI.GetComponent<HPdisplay>().UpdateHP(HPcurrentPlayer);

            if (HPcurrentPlayer <= 0)
            {
                Playerdeath();
            }
        }
        // heals player when potion is picked up
        if (other.tag == "potion")
        {
            HPcurrentPlayer += Potionheal;
            HPdisplayUI.GetComponent<HPdisplay>().UpdateHP(HPcurrentPlayer);

        }
    }

    //debug for player HP in UI display and deathUI
    /* private void Update()
     {
         if (Input.GetKeyDown(KeyCode.L))
         {
             HPcurrentPlayer -= weapondamageOnPlayer;
             HPdisplayUI.GetComponent<HPdisplay>().UpdateHP(HPcurrentPlayer);
         }
     }*/

    // triggers game over screen
    void Playerdeath()
      {
        Gameoverscreen.SetActive(true);
      }
}
