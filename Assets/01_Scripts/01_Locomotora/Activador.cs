using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador : MonoBehaviour
{
    public Follower movimientoTren;
    public GameObject temp0, temp1;
    public GameObject ruedas, trenAndando, trenfrenado;
    public AudioSource Palanca1;


    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Palanca"))
        {
            movimientoTren.enabled = true;
            temp0.SetActive(false);
            temp1.SetActive(true);
            Palanca1.Play();
            trenAndando.SetActive(true);
            trenfrenado.SetActive(false);
            StartCoroutine(sonido());

        }
    }

    IEnumerator sonido()
    {
        yield return new WaitForSeconds(3);
        ruedas.SetActive(true);
    }
}
