using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class potion : MonoBehaviour
{
    public AudioClip drinkpotion;
    public AudioSource soundsource;

    private void Start()
    {
        soundsource.clip = drinkpotion;

    }

    private void OnTriggerEnter(Collider other)
    { //adds hp when a potion is picked up and plays sound
        if (other.tag == "Player")
        {
            soundsource.Play();
            Destroy(this.gameObject);
        }
    }
}
