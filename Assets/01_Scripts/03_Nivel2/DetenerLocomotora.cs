using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetenerLocomotora : MonoBehaviour
{
    public GameObject caja;
    public GameObject ruedas, palancaTrucada, carbonApagandoce, pFire1, pFire2, pFire3, ballena2, trenAndando, trenfrenado;
    public Follower movimientoTren;
    public AguaSube aguaSube;
    public GameManager gameManager;
    public GameObject temp0, temp1;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("hola"))
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
            movimientoTren.velocidad = movimientoTren.velocidad = 0;
            trenAndando.SetActive(false);
            trenfrenado.SetActive(true);
            ballena2.SetActive(true);

            LoadScene();

        }
    }

    public void LoadScene()
    {
        StartCoroutine(desactivar());
    }

    IEnumerator desactivar()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(2);
    }


}
