using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class gameManager : MonoBehaviour
{
    public Datos misDatos;
    public GameObject panelUI;
    public GameObject canvasPreguntas;
    public bool[] chPreguntas1, chPreguntas2;
    public int indice;
    public int contadorPreguntas;
    public Texture texture;
    public TMP_Text[] botones, botones2;
    public string rtaPlayer1,rtaPlayer2;
    public GameObject CanvasPreguntas1, CanvasPreguntas2;
    public GameObject player1, player2;
    public bool movimientoP1=true;
    public bool movimientoP2=true;

    public GameObject CheckpointAct;
    public GameObject CheckpointAct2;

    public Vector3 lastCheckpoint;
    public Vector3 rotacion1, rotacion2;
    public Vector3 rotacionp1, rotacionp2;
    public Vector3 pastCheckpoint;
    public Vector3 lastCheckpoint2;
    public Vector3 pastCheckpoint2;
    public bool tp=false;
    public bool tp2=false;
    public bool checkP1;
    public bool checkP2;
    
    void Start()
    {
        checkP1 = false;
        checkP2 = false;
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(canvasPreguntas.gameObject);

        string filePat = Application.streamingAssetsPath + "/" + "data1.json";

        if (File.Exists(filePat))
        {
            string s = File.ReadAllText(filePat);
            misDatos = JsonUtility.FromJson<Datos>(s);

            s = JsonUtility.ToJson(misDatos, true);
            Debug.Log(s);
            File.WriteAllText(filePat, s);

            
        }else{
            misDatos = new Datos();
            string s = JsonUtility.ToJson(misDatos, true);
            Debug.Log(s);
            File.WriteAllText(filePat, s);            
        }
        chPreguntas1 =new bool[9];
        chPreguntas2 = new bool[9];

    }

    public void guardaDatos()
    {
        string filePat = Application.streamingAssetsPath + "/" + "data1.json";
        string s = JsonUtility.ToJson(misDatos, true);
        File.WriteAllText(filePat, s);
    }

    public void guardaArchivo()
    {
        string filePat = Application.streamingAssetsPath + "/" + "data1.json";
        string s = JsonUtility.ToJson(misDatos, true);
        File.WriteAllText(filePat, s);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void checkRespuesta(int indexButton){
        string respuestaSeleccionada = botones[indexButton].text;
        Debug.Log(respuestaSeleccionada);
        if (respuestaSeleccionada == rtaPlayer1)
        {
            Debug.Log("Respuesta correcta");
            player1.GetComponent<Movimientorotacion>().movimientoP1 = true;
            if(CheckpointAct != null)
            {
                Destroy(CheckpointAct);
                CheckpointAct = null;
                chPreguntas1[indice] = true;
            }
            checkP1 = false;
        }
        else
        {
            player1.GetComponent<Movimientorotacion>().movimientoP1 = true;
            Debug.Log("Respuesta falsa");
            tp = true;
            checkP1 = true;
            Debug.Log(checkP1 + "gm");
        }
        
        CanvasPreguntas1.SetActive(false);
    }

    public void checkRespuesta2(int indexButton)
    {
        string respuestaSeleccionada2 = botones2[indexButton].text;
        Debug.Log(respuestaSeleccionada2);
        if(respuestaSeleccionada2 == rtaPlayer2)
        {
            Debug.Log("Respuesta correcta2");
            player2.GetComponent<Movimientorotacion>().movimientoP2 = true;
            if (CheckpointAct2 != null)
            {
                Destroy(CheckpointAct2);
                CheckpointAct2 = null;
                chPreguntas2[indice] = true;
            }
            checkP2 = false;
        }
        else
        {
            player2.GetComponent<Movimientorotacion>().movimientoP2 = true;
            Debug.Log("Respuesta falsa2");
            tp2 = true;
            checkP2 = true;
        }
        CanvasPreguntas2.SetActive(false);
    }
     
}
