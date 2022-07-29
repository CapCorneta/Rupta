using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PararLevel3 : MonoBehaviour
{
    public Follower movimientoTren;
    public GameObject temp0, temp1;
    public GameObject ruedas, hola;
    public GameObject palancaTrucada, carbonApagandoce, pFire1, pFire2, pFire3, carbon, carbontrucho, trenAndando, trenfrenado, spawnreal, spawnreal2;
    public GameObject caja;
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Palanca"))
        {
            caja.SetActive(false);
            ruedas.SetActive(false);
            movimientoTren.enabled = false;
            palancaTrucada.SetActive(true);
            caja.SetActive(false);
            carbonApagandoce.SetActive(true);
            pFire1.SetActive(false);
            pFire2.SetActive(false);
            pFire3.SetActive(false);
            gameManager.cantidad = 0;
            temp0.SetActive(true);
            temp1.SetActive(false);
            carbon.SetActive(false);
            carbontrucho.SetActive(false);
            movimientoTren.velocidad = movimientoTren.velocidad = 0;
            trenAndando.SetActive(false);
            trenfrenado.SetActive(true);
            spawnreal.SetActive(true);
            spawnreal2.SetActive(true);

            Destroy(hola);
            
        }
    }



}
