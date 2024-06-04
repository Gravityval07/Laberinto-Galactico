using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float TiempoRestante;

    public string GameOver;

    void Update()
    {
        if (TiempoRestante > 0)
        {
            TiempoRestante -= Time.deltaTime;
        }
        else if (TiempoRestante < 0)
        {
            TiempoRestante = 0;
            SceneManager.LoadScene("GameOver");
        }
        
        int minutes = Mathf.FloorToInt(TiempoRestante / 60);
        int seconds = Mathf.FloorToInt(TiempoRestante % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        
    }
}
