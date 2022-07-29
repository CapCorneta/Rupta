using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScena2 : MonoBehaviour
{


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tren"))
        {
            LoadScene();
        }
    }

    public void LoadScene()
    {
        StartCoroutine(desactivar());
    }

    IEnumerator desactivar()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }
}
