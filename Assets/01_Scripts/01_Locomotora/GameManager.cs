using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int cantidad = 0;
    public int temperatura = 10;
    public GameObject caja;
    public GameManager gameManager;
    public GameObject ruedas, palancaTrucada, carbonApagandoce, pFire1, pFire2, pFire3, trenReanudando, trenfrenando, temV, temR, temA, velocidad0, velocidad1;
    public Follower movimientoTren;
    public Slider temp;
    public Slider tempVERDE;
    public Slider tempROJO;
    public Slider tempZUL;



    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("").GetComponent<GameManager>();
    }

    private void Update()
    {
        temp.value = cantidad;
        tempVERDE.value = temperatura;
        tempROJO.value = temperatura;
        tempZUL.value = temperatura;

        if (temperatura >= 18)
        {
            caja.SetActive(false);
            ruedas.SetActive(false);
            movimientoTren.enabled = false;
            palancaTrucada.SetActive(true);
            caja.SetActive(false);
            carbonApagandoce.SetActive(true);
            pFire1.SetActive(false);
            pFire2.SetActive(false);
            pFire3.SetActive(false);
            gameManager.cantidad = 0;
            movimientoTren.velocidad = movimientoTren.velocidad = 0;
        }

        if (temperatura >=  13)
        {
            temA.SetActive(false);
            temV.SetActive(false);
            temR.SetActive(true);
        }

        if (temperatura <= 12)
        {
            temA.SetActive(false);
            temV.SetActive(true);
            temR.SetActive(false);
        }

        if (temperatura <= 7)
        {
            temA.SetActive(true);
            temV.SetActive(false);
            temR.SetActive(false);
        }
       
       else  if(temperatura <= 8)
        {
            temA.SetActive(false);
            temV.SetActive(true);
            temR.SetActive(false);
        }
        


        else if (temperatura <= 5)
        {
            caja.SetActive(false);
            ruedas.SetActive(false);
            movimientoTren.enabled = false;
            palancaTrucada.SetActive(true);
            caja.SetActive(false);
            carbonApagandoce.SetActive(true);
            pFire1.SetActive(false);
            pFire2.SetActive(false);
            pFire3.SetActive(false);
            gameManager.cantidad = 0;
            movimientoTren.velocidad = movimientoTren.velocidad = 0;
        }

        if (cantidad == 1)
        {
            pFire1.SetActive(true);
            pFire2.SetActive(false);
        }

        if(cantidad == 6)
        {
            
            pFire3.SetActive(true);
        }

        if (cantidad == 3)
        {
            caja.SetActive(true);
            palancaTrucada.SetActive(false);
            carbonApagandoce.SetActive(false);
            pFire2.SetActive(true);
            pFire3.SetActive(false);
            


        }

        if(cantidad == 1)
        {
            trenfrenando.SetActive(false);
        }

        if (cantidad == 0)
        {
            caja.SetActive(false);
            ruedas.SetActive(false);
            movimientoTren.enabled = false;
            palancaTrucada.SetActive(true);
            caja.SetActive(false);
            carbonApagandoce.SetActive(true);
            pFire1.SetActive(false);
            pFire2.SetActive(false);
            pFire3.SetActive(false);
            trenfrenando.SetActive(true);
            trenReanudando.SetActive(false);
            movimientoTren.velocidad = movimientoTren.velocidad = 0;
            velocidad0.SetActive(true);
            velocidad1.SetActive(false);

        }
        

    }   
}
