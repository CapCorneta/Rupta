using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parartren2 : MonoBehaviour
{
    public Follower movimientoTren;
    public GameObject temp0, temp1;
    public GameObject ruedas, trenAndando, trenfrenado, caja;
    
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tren"))
        {
            movimientoTren.enabled = false;
            temp0.SetActive(true);
            temp1.SetActive(false);
            ruedas.SetActive(false);
            trenAndando.SetActive(false);
            trenfrenado.SetActive(true);
            Destroy(caja);
        }
    }
}
