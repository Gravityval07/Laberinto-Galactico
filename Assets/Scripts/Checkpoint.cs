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
    public TMP_Text txtPregunta1, txtPregunta2;
    public TMP_Text txtRespuesta1, txtRespuesta2, txtRespuesta3, txtRespuesta4;
    string pregunta;
    string rta1;
    string rta2;
    string rta3;
    string rta4;
    public int contadorPreguntas;
    public RawImage[] optionsContainer;
    public Texture texture;
    private string respuesta, respuesta2;

    public bool checkP1;
    public bool checkP2;
    
    void Start()
    {
        contadorPreguntas = 0;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player1"))
        {
            gameManager gm = FindObjectOfType<gameManager>();
            if (gm != null)
            {
                gm.CheckpointAct = gameObject;
            }
            
            if (contadorPreguntas <= 7)
            {
                bool repetido = true;
                while (repetido == true)
                {
                    indice = Random.Range(0, 8);
                    repetido = GameObject.Find("GameManager").GetComponent<gameManager>().chPreguntas1[indice];
                }
            }
            if (!checkP1)
            {
                other.GetComponent<Movimientorotacion>().pastCheckpoint = other.GetComponent<Movimientorotacion>().lastCheckpoint;
                other.GetComponent<Movimientorotacion>().lastCheckpoint = GetComponent<Transform>().position;
            }

            pregunta = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].preguntaTexto;
            rta1 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta1;
            rta2 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta2;
            rta3 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta3;
            rta4 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta4;
            respuesta = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuestaCorrecta;
            GameObject.Find("GameManager").GetComponent<gameManager>().rtaPlayer1 = respuesta;
            CanvasPreguntas1.SetActive(true);
            txtPregunta1.text = pregunta;
            txtRespuesta1.text = rta1;
            txtRespuesta2.text = rta2;
            txtRespuesta3.text = rta3;
            txtRespuesta4.text = rta4;

            contadorPreguntas++;
            texture = Resources.Load<Texture>("preguntas/" + indice + "/Casa");
            optionsContainer[0].texture = texture;
            other.GetComponent<Movimientorotacion>().movimientoP1 = false;
        }

        if (other.CompareTag("player2"))
        {
            gameManager gm = FindObjectOfType<gameManager>();
            if (gm != null)
            {
                gm.CheckpointAct2 = gameObject;
            }

            if (contadorPreguntas <= 7)
            {
                bool repetido = true;
                while (repetido == true)
                {
                    indice = Random.Range(0, 8);
                    repetido = GameObject.Find("GameManager").GetComponent<gameManager>().chPreguntas2[indice];
                }
            }
            if (!checkP2)
            {
                other.GetComponent<Movimientorotacion>().pastCheckpoint2 = other.GetComponent<Movimientorotacion>().lastCheckpoint2;
                other.GetComponent<Movimientorotacion>().lastCheckpoint2 = GetComponent<Transform>().position;
                Debug.Log("pasa2");
            }

            other.GetComponent<Movimientorotacion>().lastCheckpoint = GetComponent<Transform>().position;
            pregunta = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].preguntaTexto;
            rta1 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta1;
            rta2 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta2;
            rta3 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta3;
            rta4 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta4;
            respuesta2 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuestaCorrecta2;
            GameObject.Find("GameManager").GetComponent<gameManager>().rtaPlayer2 = respuesta2;
            CanvasPreguntas2.SetActive(true);
            txtPregunta2.text = pregunta;
            txtRespuesta1.text = rta1;
            txtRespuesta2.text = rta2;
            txtRespuesta3.text = rta3;
            txtRespuesta4.text = rta4;

            contadorPreguntas++;
            texture = Resources.Load<Texture>("preguntas/" + indice + "/Casa");
            optionsContainer[0].texture = texture;
            other.GetComponent<Movimientorotacion>().movimientoP2 = false;
        }
    }


}