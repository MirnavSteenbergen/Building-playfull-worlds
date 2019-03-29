using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerAttack : MonoBehaviour
{
    public Transform sword;
    public float hitAngle;
    public float attackSpeed = 1;
    private float cooldown = 0;
    public float totalAttackTime = 1;
    public AnimationCurve animationCurve;
    public AudioClip swooshsword;
    public AudioSource soundsource;

    private void Start()
    {
        soundsource.clip = swooshsword;

    }

    // Attackcooldown so player doesn't spam attack
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && cooldown < 0)
        {
            soundsource.Play();
            StartCoroutine(SwordAnimation());
            cooldown = attackSpeed;
        }
    }

    // attack animation
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
