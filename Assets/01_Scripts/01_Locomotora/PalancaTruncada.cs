using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalancaTruncada : MonoBehaviour
{
    public AudioSource palancaTruncada;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Palanca"))
        {
            palancaTruncada.Play();
        }
    }
     
}
