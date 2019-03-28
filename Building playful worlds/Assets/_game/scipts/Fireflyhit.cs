using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireflyhit : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Net")
        {
            Destroy(this.gameObject);
        }
    }
}
