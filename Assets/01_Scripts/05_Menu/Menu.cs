using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Menu : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {
        StartCoroutine(espera(sceneName));
    }
    IEnumerator espera(String sceneName)
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(sceneName);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("salio del juego");
    }
}
