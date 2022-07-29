using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VolumenLogic : MonoBehaviour
{
    public Slider slider;
    public GameObject[] audios;

    private void Start()
    {
        audios = GameObject.FindGameObjectsWithTag("audio");
        slider.value = PlayerPrefs.GetFloat("volumenSave", 1f);
    }

    private void Update()
    {
        foreach (GameObject au in audios)
            au.GetComponent<AudioSource>().volume = slider.value;
    }

    public void guardarVolumen()
    {
        PlayerPrefs.SetFloat("volumenSave", slider.value);
    }



    public void bajarVolumen()
    {
        slider.value = slider.value - 0.1f;

    }

    public void SubirVolumen()
    {
        slider.value = slider.value + 0.1f;

    }
}
