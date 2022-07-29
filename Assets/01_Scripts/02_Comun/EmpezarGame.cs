using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarGame : MonoBehaviour
{
    public GameObject trans;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LoadScene();
            trans.SetActive(true);
        }
    }

    public void LoadScene()
    {
        StartCoroutine(desactivar());
    }

    IEnumerator desactivar()
    {
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(1);
    }
}

