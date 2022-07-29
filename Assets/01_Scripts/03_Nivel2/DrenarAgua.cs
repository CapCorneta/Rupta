using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrenarAgua : MonoBehaviour
{
    
    public float velocidad;
    public DrenarAgua drenarAgua;
    public AguaSube aguaSube;

    private void Start()
    {
      StartCoroutine(Delay());        
    }

    private void Update()
    {
        transform.Translate(new Vector3(0f, -1f, 0f) * velocidad * Time.deltaTime);    
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(3);
        drenarAgua.enabled = false;
        aguaSube.enabled = true;
    }
}
