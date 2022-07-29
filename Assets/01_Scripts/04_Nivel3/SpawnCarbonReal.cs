using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCarbonReal : MonoBehaviour
{
    public Transform firePosition;
    public GameObject efis;
    public bool spawn;
    public float delayInSeconds;
    private void Update()
    {

        if (spawn == true)
        {

            spawn = false;
            StartCoroutine(ShootDelay());

        }
    }
    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        Instantiate(efis, firePosition.position, firePosition.rotation);
        spawn = true;

    }
}
