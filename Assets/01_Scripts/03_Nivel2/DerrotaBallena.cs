using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DerrotaBallena : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("tren"))
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
        SceneManager.LoadScene(2);
    }
}
