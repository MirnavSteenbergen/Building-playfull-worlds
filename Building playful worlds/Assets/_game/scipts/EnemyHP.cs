using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int HPmax = 10;
    private int HPcurrent;
    public int weapondamage = 1;

    // Start is called before the first frame update
    void Start()
    {
        HPcurrent = HPmax;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "weapon")
        {
            HPcurrent -= weapondamage;
            
            if (HPcurrent <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
