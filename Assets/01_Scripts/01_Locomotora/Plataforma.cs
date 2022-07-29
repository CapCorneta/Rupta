using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.parent = transform;
    }
}
