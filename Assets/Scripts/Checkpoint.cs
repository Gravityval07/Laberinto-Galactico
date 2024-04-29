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
    public int contadorPreguntas;
    public RawImage[] optionsContainer;
    public Texture texture;

    void Start()
    {
        contadorPreguntas=0;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("player1"))
        {
            if(contadorPreguntas<=3)
            {
                bool repetido= true;
                while(repetido == true)
                {
                    indice=Random.Range(0,4);
                    repetido= GameObject.Find("GameManager").GetComponent<gameManager>().chPreguntas[indice];
                }
            }

            other.GetComponent<Movimientorotacion>().lastCheckpoint = GetComponent<Transform>().position;
            Destroy(gameObject);
            pregunta = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice];
            CanvasPreguntas1.SetActive(true);
            txtPregunta1.text = pregunta;
            GameObject.Find("GameManager").GetComponent<gameManager>().chPreguntas[indice]=true;
            contadorPreguntas++;
            //indice = GameObject.Find("GameManager").GetComponent<gameManager>().indice;
            texture = Resources.Load<Texture>("preguntas/" + indice + "/Casa");
            optionsContainer[0].texture = texture;
            
        }

        if (other.CompareTag("player2"))
        {
             if(contadorPreguntas<=3)
            {
                bool repetido= true;
                while(repetido == true)
                {
                    indice=Random.Range(0,4);
                    repetido=GameObject.Find("GameManager").GetComponent<gameManager>().chPreguntas[indice];
                }
            }

            other.GetComponent<Movimientorotacion>().lastCheckpoint = GetComponent<Transform>().position;
            Destroy(gameObject);
            pregunta = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice];
            CanvasPreguntas2.SetActive(true);
            txtPregunta2.text =  pregunta;
            GameObject.Find("GameManager").GetComponent<gameManager>().chPreguntas[indice]=true;
            contadorPreguntas++;
            texture = Resources.Load<Texture>("preguntas/" + indice + "/Casa");
            optionsContainer[0].texture = texture;
        }
    }

        
}