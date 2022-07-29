using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoMalulo : MonoBehaviour
{

    public int rutina;
    public float cronometro;
    public Quaternion angulo;
    public float grado;

    public GameObject target;
    public bool atacando;

    public void Start()
    {
        target = GameObject.Find("Player");
    }
    public void Comportamiento_Enemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 20)
        {
            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 4)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
            }
            switch (rutina)
            {
                case 0:
                    break;

                case 1:
                    grado = Random.Range(0, 360);
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++;
                    break;

                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.3f);
                    transform.Translate(Vector3.forward * 0.3f * Time.deltaTime);
                    break;

            }
        }
        else
        {
            if (Vector3.Distance(transform.position, target.transform.position) > 1! && !atacando)
            {
                var lookPos = target.transform.position - transform.position;
                lookPos.y = 0;
                var rotation = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 3);


                transform.Translate(Vector3.forward * 0.8f * Time.deltaTime);


            }
            else
            {
                atacando = true;
            }
        }

    }

    public void Final_Ani()
    {

        atacando = false;
    }

    private void Update()
    {
        Comportamiento_Enemigo();
    }
}
