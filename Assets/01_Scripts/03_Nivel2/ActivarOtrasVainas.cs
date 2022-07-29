using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarOtrasVainas : MonoBehaviour
{
    public DrenarAgua drenarAgua;
    public AguaSube aguaSube;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cuerda"))
        {
            drenarAgua.enabled = true;
            aguaSube.enabled = false;
        }
    }
}
