using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float attackSpeed = 2;
    private float cooldown = 0;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if(cooldown < 0)
        {
            StartCoroutine(AttackAnimation());
            cooldown = attackSpeed;
        }
    }

    IEnumerator AttackAnimation()
    {
        anim.SetBool("Attack", true);
        yield return new WaitForSeconds(anim.GetCurrentAnimatorStateInfo(0).length);
        anim.SetBool("Attack", false);
    }
}
