using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class gameManager : MonoBehaviour
{
    public Datos misDatos;
    public GameObject panelUI;
    // Start is called before the first frame update
    void Start()
    {
        /*DontDestroyOnLoad(this.gameObject);
        GameObject canvas = GameObject.Find("Canvas");
        DontDestroyOnLoad(canvas.gameObject);*/

        string filePat = Application.streamingAssetsPath + "/" + "data1.json";

        if (File.Exists(filePat))
        {
            string s = File.ReadAllText(filePat);
            misDatos = JsonUtility.FromJson<Datos>(s);

            s = JsonUtility.ToJson(misDatos, true);
            Debug.Log(s);
            File.WriteAllText(filePat, s);
        }
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
}
