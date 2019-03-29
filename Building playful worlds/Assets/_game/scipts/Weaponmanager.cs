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
    { // when E is pressed weapon will be switched
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
        // determine which weapon to show and set it active
        for (int i = 0; i < weapons.Length; i++)
            weapons[i].gameObject.SetActive(false);

        weapons[newIndex].gameObject.SetActive(true);

    }
}
