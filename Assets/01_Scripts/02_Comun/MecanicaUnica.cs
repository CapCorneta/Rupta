using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicaUnica : MonoBehaviour
{
    public GameObject mecanicaUnica, silbaro;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tren"))
        {
            mecanicaUnica.SetActive(true);
            silbaro.SetActive(false);
        }
    }
}
