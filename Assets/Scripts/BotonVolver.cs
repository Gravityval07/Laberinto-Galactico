using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonVolver : MonoBehaviour
{
    public void EscenaVolver()
    {
        SceneManager.LoadScene("MenuInicio");
    }
}