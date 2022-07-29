using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalancaGrab : MonoBehaviour
{
    public Transform handler;
   
    void Update()
    {
        transform.position = handler.transform.position;
        transform.rotation = handler.transform.rotation;

        Rigidbody rbhandler = handler.GetComponent<Rigidbody>();
        rbhandler.velocity = Vector3.zero;
        rbhandler.angularVelocity = Vector3.zero;
    }
}
