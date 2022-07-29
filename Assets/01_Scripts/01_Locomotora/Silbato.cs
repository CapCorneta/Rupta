using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Silbato : MonoBehaviour
{
    public GameObject silbato;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cuerda"))
        {
            silbato.SetActive(true);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cuerda"))
        {
            silbato.SetActive(false);
        }
            
    }
}    

