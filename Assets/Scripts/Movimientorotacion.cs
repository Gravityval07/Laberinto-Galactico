using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientorotacion : MonoBehaviour
{
    public Vector3 vectorRotacion;
    public float speed;
    private new Rigidbody rigidbody;
    public float movementSpeed;
    Vector3 velocity = Vector3.zero;
    public GameObject PanelPP1;
    public GameObject PanelPP2;
    public Vector3 lastCheckpoint;

    void Start()
    {
        vectorRotacion = this.transform.localEulerAngles;
        rigidbody = GetComponent<Rigidbody>();
        
    }

    void Update()
    { 
        
        if(this.tag=="player1")
        { 
            
            if (Input.GetKey(KeyCode.UpArrow))
            {
                
                 Vector3 direction = (transform.forward * 1).normalized;
                    rigidbody.velocity = direction * movementSpeed;
            }
             else
            {
            rigidbody.velocity = Vector3.zero;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                Vector3 direction = (transform.forward * -1).normalized;
                    rigidbody.velocity = direction * movementSpeed;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                vectorRotacion =new Vector3(0,speed*Time.deltaTime,0);
                //this.transform.localEulerAngles = vectorRotacion;
                this.transform.Rotate(vectorRotacion,Space.Self);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                vectorRotacion =- new Vector3(0,speed*Time.deltaTime,0);
                //this.transform.localEulerAngles = vectorRotacion;
                this.transform.Rotate(vectorRotacion,Space.Self);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                PanelPP1.SetActive(false);
                Time.timeScale = 1f;
                transform.position = lastCheckpoint;

            }
        }

        if(this.tag=="player2")
        {
            if (Input.GetKey(KeyCode.D))
            {
                vectorRotacion =new Vector3(0,speed*Time.deltaTime,0);
                //this.transform.localEulerAngles = vectorRotacion;
                this.transform.Rotate(vectorRotacion,Space.Self);
            }

            if (Input.GetKey(KeyCode.A))
            {
                vectorRotacion = -new Vector3(0,speed*Time.deltaTime,0);
                //this.transform.localEulerAngles = vectorRotacion;
                this.transform.Rotate(vectorRotacion,Space.Self);
            }

            if (Input.GetKey(KeyCode.W))
            {
                Vector3 direction = (transform.forward * 1).normalized;
                rigidbody.velocity = direction * movementSpeed;
            }

            if (Input.GetKey(KeyCode.S))
            {
                Vector3 direction = (transform.forward * -1).normalized;
                rigidbody.velocity = direction * movementSpeed;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                PanelPP2.SetActive(false);
                Time.timeScale = 1f;
                transform.position = lastCheckpoint;

            }
        }
    }
}

