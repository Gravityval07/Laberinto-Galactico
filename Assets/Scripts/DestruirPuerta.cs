using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPuerta : MonoBehaviour
{
    public GameObject Panel1PP2;

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        Panel1PP2.SetActive(true);

    }
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Time.timeScale = 1f;
                Panel1PP2.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}
