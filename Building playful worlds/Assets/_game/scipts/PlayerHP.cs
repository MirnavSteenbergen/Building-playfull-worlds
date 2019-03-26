using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int HPmaxPlayer = 10;
    public int HPcurrentPlayer;
    public int weapondamageOnPlayer = 1;
    public GameObject HPdisplayUI;
    public GameObject Gameoverscreen;

    // Start is called before the first frame update
    void Start()
    {
        HPcurrentPlayer = HPmaxPlayer;
        HPdisplayUI.GetComponent<HPdisplay>().UpdateHP(HPcurrentPlayer);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "weaponEnemy")
        {
            HPcurrentPlayer -= weapondamageOnPlayer;
            HPdisplayUI.GetComponent<HPdisplay>().UpdateHP(HPcurrentPlayer);

            if (HPcurrentPlayer <= 0)
            {
                Playerdeath();
            }
        }
    }

   /* private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            HPcurrentPlayer -= weapondamageOnPlayer;
            HPdisplayUI.GetComponent<HPdisplay>().UpdateHP(HPcurrentPlayer);
        }
    }*/

     void Playerdeath()
      {
        Gameoverscreen.SetActive(true);
      }
}
