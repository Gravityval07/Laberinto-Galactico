using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{

    public GameObject panelganador1, panelganador2;
    public GameObject paneltimer;
    public GameObject panelvolver;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player1"))
        {
            panelganador1.SetActive(true);
            other.GetComponent<Movimientorotacion>().movimientoP1 = false;
            other.GetComponent<Movimientorotacion>().movimientoP2 = false;
            paneltimer.SetActive(false);
            panelvolver.SetActive(true);
        }

        if (other.CompareTag("player2"))
        {
            panelganador2.SetActive(true);
            other.GetComponent<Movimientorotacion>().movimientoP1 = false;
            other.GetComponent<Movimientorotacion>().movimientoP2 = false;
            paneltimer.SetActive(false);
            panelvolver.SetActive(true);
        }
    }
}