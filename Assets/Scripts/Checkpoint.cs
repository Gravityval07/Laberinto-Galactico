using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("player1"))
        {
            other.GetComponent<Movimientorotacion>().lastCheckpoint = GetComponent<Transform>().position;
            Destroy(gameObject);
        }

        if (other.CompareTag("player2"))
        {
            other.GetComponent<Movimientorotacion>().lastCheckpoint = GetComponent<Transform>().position;
            Destroy(gameObject);
        }
    }

        
}