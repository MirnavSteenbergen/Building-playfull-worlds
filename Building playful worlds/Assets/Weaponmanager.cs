using UnityEngine;

public class Weaponmanager : MonoBehaviour
{
    public GameObject[] weapons;
    private int index;

    // Start is called before the first frame update
    private void Start()
    {
        SwitchWeapon(0);
    }


   

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            index++;

            if (index > weapons.Length - 1)
                index = 0;

            SwitchWeapon(index);
        }
    }

    private void SwitchWeapon(int newIndex)
    {
        
        for (int i = 0; i < weapons.Length; i++)
            weapons[i].gameObject.SetActive(false);

        weapons[newIndex].gameObject.SetActive(true);

    }
}
