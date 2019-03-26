using System.Collections;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int HPmax = 10;
    private int HPcurrent;
    public int weapondamage = 1;
    [SerializeField]
    private Animator anim;

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
                anim.SetBool("Walk", false);
                anim.SetBool("Attack", false);
                anim.SetTrigger("Death");
                StartCoroutine(Death());
            }
        }
    }

    private IEnumerator Death()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
