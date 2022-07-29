using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recuperartodo : MonoBehaviour
{
    public GameObject carbon, carbontrucho, spawnreal;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Palanca"))
        {

            carbon.SetActive(true);
            carbontrucho.SetActive(true);
            spawnreal.SetActive(false);
        }
    }
}
