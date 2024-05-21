using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[System.Serializable]
public class Datos : System.Object
{ 

    [SerializeField]
    public List<pregunta> preguntas;

    


    public Datos()
        {
            pregunta nuevaPregunta = new pregunta();
            this.preguntas = new List<pregunta>();
            this.preguntas.Add(nuevaPregunta);
        }

    // Start is called before the first frame update
    

    // Update is called once per frame
    private void Update()
    {
        
    }
}


[System.Serializable]
public class pregunta : System.Object
{ 
    [SerializeField]
    public string preguntaTexto;
    [SerializeField]
    public string respuesta1;
    [SerializeField]
    public string respuesta2;
    [SerializeField]
    public string respuesta3;
    [SerializeField]
    public string respuesta4;
    public pregunta(){
        this.preguntaTexto="PreguntaEjemplo";
        this.respuesta1 = "Respuesta1";
        this.respuesta2 = "Respuesta2";
        this.respuesta3 = "Respuesta3";
        this.respuesta4 = "Respuesta4";
    }
}
