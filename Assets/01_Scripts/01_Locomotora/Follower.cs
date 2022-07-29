using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.UI;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float velocidad;
    float distanceTravelled;
    public Slider velo;

    private void Update()
    {
        distanceTravelled += velocidad* Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        velo.value = velocidad;
    }
}
