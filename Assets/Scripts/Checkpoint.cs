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
    public TMP_Text txtRespuesta1, txtRespuesta2, txtRespuesta3, txtRespuesta4;
    string pregunta;
    string rta1;
    string rta2;
    string rta3;
    string rta4;
    public int contadorPreguntas;
    public RawImage[] optionsContainer;
    public Texture texture;

    //public bool[] bRespuestas;
    //bPreguntas =new bool[4];

    void Start()
    {
        contadorPreguntas=0;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("player1"))
        {
            if (contadorPreguntas <= 7)
            {
                bool repetido = true;
                while (repetido == true)
                {
                    indice = Random.Range(0, 8);
                    repetido = GameObject.Find("GameManager").GetComponent<gameManager>().chPreguntas1[indice];
                }
            }
            //else { GameObject.Find("GameManager").GetComponent<gameManager>().chPreguntas1 = new bool[8]; }

            other.GetComponent<Movimientorotacion>().lastCheckpoint = GetComponent<Transform>().position;
            Destroy(gameObject);
            pregunta = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].preguntaTexto;
            rta1 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta1;
            rta2 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta2;
            rta3 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta3;
            rta4 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta4;
            CanvasPreguntas1.SetActive(true);

            /*bool rep = true;
            while (rep == true)
            {
                indiceResp = Random.Range(0, 3);
                repetido = GameObject.Find("GameManager").GetComponent<gameManager>().bRespuestas[indice];
            }
            */
            txtPregunta1.text = pregunta;
            txtRespuesta1.text = rta1;
            txtRespuesta2.text = rta2;
            txtRespuesta3.text = rta3;
            txtRespuesta4.text = rta4;
            

            GameObject.Find("GameManager").GetComponent<gameManager>().chPreguntas1[indice]=true;
            contadorPreguntas++;
            //indice = GameObject.Find("GameManager").GetComponent<gameManager>().indice;
            texture = Resources.Load<Texture>("preguntas/" + indice + "/Casa");
            optionsContainer[0].texture = texture;

            other.GetComponent<Movimientorotacion>().movimientoP1 = false;
            
        }


        if (other.CompareTag("player2"))
        {
             if(contadorPreguntas<=7)
            {
                bool repetido= true;
                while(repetido == true)
                {
                    indice=Random.Range(0,8);
                    repetido=GameObject.Find("GameManager").GetComponent<gameManager>().chPreguntas2[indice];
                }
            }

            other.GetComponent<Movimientorotacion>().lastCheckpoint = GetComponent<Transform>().position;
            Destroy(gameObject);
            pregunta = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].preguntaTexto;
            rta1 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta1;
            rta2 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta2;
            rta3 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta3;
            rta4 = GameObject.Find("GameManager").GetComponent<gameManager>().misDatos.preguntas[indice].respuesta4;
            CanvasPreguntas2.SetActive(true);
            txtPregunta2.text =  pregunta;
            txtRespuesta1.text = rta1;
            txtRespuesta2.text = rta2;
            txtRespuesta3.text = rta3;
            txtRespuesta4.text = rta4;

            GameObject.Find("GameManager").GetComponent<gameManager>().chPreguntas2[indice]=true;
            contadorPreguntas++;
            texture = Resources.Load<Texture>("preguntas/" + indice + "/Casa");
            optionsContainer[0].texture = texture;

            other.GetComponent<Movimientorotacion>().movimientoP2 = false;
        }
    }

        
}