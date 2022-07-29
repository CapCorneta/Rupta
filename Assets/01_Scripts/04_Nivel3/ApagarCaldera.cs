using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApagarCaldera : MonoBehaviour
{

    public GameObject fire1, fire2, fire3, transicion, tapacalderaa, musica1, musica2, musica3, ruedas, sonidoFuego1, sonidoFuego2, sonidoFuego3, ashes;
    public Follower follow;
    public GameManager gameManager;

  
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tren"))
        {
            StartCoroutine(FIRE3());
            follow.enabled = false;
            gameManager.temperatura = gameManager.temperatura = 10;
            gameManager.cantidad = gameManager.cantidad = 20;
            tapacalderaa.SetActive(false);
           
        
        }
    }

    IEnumerator FIRE3()
    {
        yield return new WaitForSeconds(5);
        fire3.SetActive(false);
        musica3.SetActive(false);
        StartCoroutine(FIRE2());
        sonidoFuego1.SetActive(false);
        
    }

    IEnumerator FIRE2()
    {
        yield return new WaitForSeconds(5);
        fire2.SetActive(false);
        musica2.SetActive(false);
        StartCoroutine(FIRE1());
        sonidoFuego2.SetActive(false);
    }

    IEnumerator FIRE1()
    {
        yield return new WaitForSeconds(5);
        fire1.SetActive(false);
        transicion.SetActive(true);
        musica1.SetActive(false);
        ruedas.SetActive(false);
        StartCoroutine(desactivar());
        sonidoFuego3.SetActive(false);
        ashes.SetActive(false);
    }

    IEnumerator desactivar()
    {
        yield return new WaitForSeconds(6);

        SceneManager.LoadScene(4);
    }


}
