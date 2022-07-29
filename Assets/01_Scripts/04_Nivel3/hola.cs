using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject fire1, fire2, fire3, teleporPoints, sonidoFuego1, sonidoFuego2, sonidoFuego3, sonidoFuego0, ashes;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tren"))
        {
            fire1.layer = 3;
            fire2.layer = 3;
            fire3.layer = 3;
            ashes.layer = 3;
            fire2.SetActive(true);
            fire3.SetActive(true);
            fire1.SetActive(true);
            ashes.SetActive(true);
            teleporPoints.SetActive(false);
            sonidoFuego1.SetActive(true);
            sonidoFuego2.SetActive(true);
            sonidoFuego3.SetActive(true);
            sonidoFuego0.SetActive(false);
            gameManager.temperatura = gameManager.temperatura = 10;


        }
    }

}
