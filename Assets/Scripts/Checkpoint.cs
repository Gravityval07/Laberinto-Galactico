using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class Checkpoint : MonoBehaviour
{
    public int indice;
    public GameObject CanvasPreguntas1, CanvasPreguntas2;
    public TMP_Text txtPregunta1,txtPregunta2;
    string pregunta;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("player1"))
        {
            other.GetComponent<Movimientorotacion>().lastCheckpoint = GetComponent<Transform>().position;
            Destroy(gameObject);
            pregunta = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice];
            CanvasPreguntas1.SetActive(true);
            txtPregunta1.text = pregunta;
        }

        if (other.CompareTag("player2"))
        {
            other.GetComponent<Movimientorotacion>().lastCheckpoint = GetComponent<Transform>().position;
            Destroy(gameObject);
            pregunta = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice];
            CanvasPreguntas2.SetActive(true);
            txtPregunta2.text =  pregunta;
            
        }
    }

        
}