using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metalrechinando : MonoBehaviour
{
    public AudioSource metalRechinado;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Valve"))
        {
            metalRechinado.Play();
        }
    }
}

