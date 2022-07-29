using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirFisica : MonoBehaviour
{
    public Transform target;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(target.transform.position);
    }
}
