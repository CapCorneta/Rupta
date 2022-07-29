using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public GameObject prota;

    private void Update()
    {
        transform.LookAt(prota.transform);
    }
}
