using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeCarbon : MonoBehaviour
{
    public GameManager gameManager;
    public Follower movimientoTren;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Caldera"))
        {
            StartCoroutine(desactivar());
        }

    }

    IEnumerator desactivar()
    {
        yield return new WaitForSeconds(200);
        gameManager.cantidad = gameManager.cantidad - 1;
        gameManager.temperatura = gameManager.temperatura - 1;
        movimientoTren.velocidad = movimientoTren.velocidad - 1;
        Destroy(gameObject);
    }
}
