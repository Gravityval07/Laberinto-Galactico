using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesGameOver : MonoBehaviour
{
    public void VolverJugar()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene("MenuInicio");
    }
}
