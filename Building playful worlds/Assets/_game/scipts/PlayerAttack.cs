using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform sword;
    public float hitAngle;
    public float attackSpeed = 1;
    private float cooldown = 0;
    public float totalAttackTime = 1;
    public AnimationCurve animationCurve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && cooldown < 0)
        {
            StartCoroutine(SwordAnimation());
            cooldown = attackSpeed;
        }
    }

    IEnumerator SwordAnimation()
    {
        float t = 0;
        Quaternion startRotation = sword.transform.localRotation;
        Quaternion endRotation = startRotation * Quaternion.Euler(0, -hitAngle, 0);
        
        while(t < 1)
        {
            t += Time.deltaTime * (1/ totalAttackTime) * 2f;
            sword.transform.localRotation = Quaternion.Lerp(startRotation, endRotation, animationCurve.Evaluate(t));
            yield return new WaitForSeconds(Time.deltaTime);
        }
        t = 0;
        while (t < 1)
        {
            t += Time.deltaTime * (1 / totalAttackTime) * 2f;
            sword.transform.localRotation = Quaternion.Lerp(endRotation, startRotation, animationCurve.Evaluate(t));
            yield return new WaitForSeconds(Time.deltaTime);
        }
        sword.transform.localRotation = startRotation;
    }
}
