using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Checkpoint : MonoBehaviour
{
    public int indice;
    public string pregunta;
    public GameObject CanvasPreguntas;
    public Text contenedorPregunta;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("player1"))
        {
            other.GetComponent<Movimientorotacion>().lastCheckpoint = GetComponent<Transform>().position;
            Destroy(gameObject);
            pregunta = GameObject.Find("gameManager").GetComponent<gameManager>().misDatos.preguntas[indice];
            CanvasPreguntas.SetActive(true);
            contenedorPregunta.text = pregunta;
        }

        if (other.CompareTag("player2"))
        {
            other.GetComponent<Movimientorotacion>().lastCheckpoint = GetComponent<Transform>().position;
            Destroy(gameObject);
            pregunta = GameObject.Find("gameManager").GetComponent<gameManager>().misDatos.preguntas[indice];
            CanvasPreguntas.SetActive(true);
            contenedorPregunta.text = pregunta;
        }
    }

        
}