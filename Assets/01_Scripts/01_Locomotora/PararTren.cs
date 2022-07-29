using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PararTren : MonoBehaviour
{
    public Follower movimientoTren;
    public GameObject temp0, temp1;
    public GameObject ruedas, trenAndando, trenfrenado;
    public AudioSource Palanca2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Palanca"))
        {
            movimientoTren.enabled = false;
            temp0.SetActive(true);
            temp1.SetActive(false);
            ruedas.SetActive(false);
            Palanca2.Play();
            trenAndando.SetActive(false);
            trenfrenado.SetActive(true);
        }
    }
}
