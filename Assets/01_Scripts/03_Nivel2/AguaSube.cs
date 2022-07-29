using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AguaSube : MonoBehaviour
{
    
    public float velocidad;

    private void Update()
    {
        transform.Translate(new Vector3(0f,1f,0f) * velocidad * Time.deltaTime);
    }
}

  
