using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.UI;

public class FishFollower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float velocidad;
    float distanceTravelled;

    private void Update()
    {
        distanceTravelled += velocidad * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }
}
