using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicaUnicaChao : MonoBehaviour
{
    public GameObject mecanicaUnica, silbaro;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tren"))
        {
            mecanicaUnica.SetActive(false);
            silbaro.SetActive(true);
        }
    }
}
