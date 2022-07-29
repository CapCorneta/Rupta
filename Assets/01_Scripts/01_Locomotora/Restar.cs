using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restar : MonoBehaviour
{

    public GameManager gameManager;
    public int scoreValue = 1;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Valve"))
        {

            gameManager.temperatura = gameManager.temperatura - 3;

        }
    }
}
