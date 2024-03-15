using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PuertaDestruir : MonoBehaviour
{

    public GameObject Panel1PP1;

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        Panel1PP1.SetActive(true);
        
    }
    void Update ()
    {
            if (Input.GetKeyDown(KeyCode.K))
            {   Time.timeScale = 1f;
                Panel1PP1.SetActive(false);
                Destroy(gameObject);
            }
    }

}