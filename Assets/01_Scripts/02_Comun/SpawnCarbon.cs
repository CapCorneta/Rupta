using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCarbon : MonoBehaviour
{
    public List<GameObject> personaje;
    private int currentIndex = 0;
    public float elapsedTime = 0f;
    public float repeatTime = 10f;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= repeatTime)
        {
            int newIndex = Random.Range(0, personaje.Count);
            personaje[currentIndex].SetActive(false);
            currentIndex = newIndex;
            personaje[currentIndex].SetActive(true);
            personaje.RemoveAt(newIndex);

            elapsedTime -= repeatTime;
        }
    }
}
