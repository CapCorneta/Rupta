using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonoTeToca : MonoBehaviour
{
    public GameObject trans, sonidomuerte, sonidoEstacion;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LoadScene();
            trans.SetActive(true);
            sonidomuerte.SetActive(true);
            sonidoEstacion.SetActive(false);
        }
    }

    public void LoadScene()
    {
        StartCoroutine(desactivar());
    }

    IEnumerator desactivar()
    {
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(3);
    }

}
