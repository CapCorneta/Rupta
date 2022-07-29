using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caldera3 : MonoBehaviour
{
    public GameManager gameManager;
    public Follower movimientoTren;
    public int scoreValue = 1;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Carbon"))
        {
            gameManager.cantidad = gameManager.cantidad + 1;
            gameManager.temperatura = gameManager.temperatura + 1;
            movimientoTren.velocidad = movimientoTren.velocidad + 3;
        }
    }
}
