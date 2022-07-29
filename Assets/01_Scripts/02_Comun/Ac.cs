using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ac : MonoBehaviour
{
    public GameObject activarCosas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tren"))
        {
            activarCosas.SetActive(true);
        }
    }

}
