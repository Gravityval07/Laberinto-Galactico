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
    public Animator Animator;
    public bool walking;
    public GameObject PanelPP2;
    public GameObject PanelPP1;
    
    public Vector3 lastCheckpoint;
    public Vector3 pastCheckpoint;
    public bool tp=false;

    public Vector3 lastCheckpoint2;
    public Vector3 pastCheckpoint2;
    public bool tp2 = false;

    public bool movimientoP1=true;
    public bool movimientoP2=true;

    public GameObject CanvasPreguntas1, CanvasPreguntas2;

    void Start()
    {
        vectorRotacion = this.transform.localEulerAngles;
        rigidbody = GetComponent<Rigidbody>();
        pastCheckpoint = new Vector3(-8.597191f, 0.114f, -4.239875f);
        lastCheckpoint = new Vector3(-8.597191f, 0.114f, -4.239875f);

        pastCheckpoint2 = new Vector3(5.735f, 0.114f, -3.217f);
        lastCheckpoint2 = new Vector3(5.735f, 0.114f, -3.217f);
    }

    void Update()
    { 
        if(this.tag=="player1")
        { 
            if (Input.GetKey(KeyCode.UpArrow)&& movimientoP1)
            {
                Vector3 direction = (transform.forward * 1).normalized;
                rigidbody.velocity = direction * movementSpeed;
                Animator.SetTrigger("Caminar");
                Animator.ResetTrigger("Idle");
                walking = true;
            }
            else
            {
                rigidbody.velocity = Vector3.zero;
                Animator.SetTrigger("Idle");
                Animator.ResetTrigger("Caminar");
                walking = false;
            }

            if (Input.GetKey(KeyCode.DownArrow) && movimientoP1)
            {
                Vector3 direction = (transform.forward * -1).normalized;
                rigidbody.velocity = direction * movementSpeed;
            }

            if (Input.GetKey(KeyCode.RightArrow) && movimientoP1)
            {
                vectorRotacion =new Vector3(0,speed*Time.deltaTime,0);
                //this.transform.localEulerAngles = vectorRotacion;
                this.transform.Rotate(vectorRotacion,Space.Self);
            }

            if (Input.GetKey(KeyCode.LeftArrow) && movimientoP1)
            {
                vectorRotacion =- new Vector3(0,speed*Time.deltaTime,0);
                //this.transform.localEulerAngles = vectorRotacion;
                this.transform.Rotate(vectorRotacion,Space.Self);
            }
            
            if (GameObject.Find("GameManager").GetComponent<gameManager>().tp)
            {
                transform.position = pastCheckpoint;
                GameObject.Find("GameManager").GetComponent<gameManager>().tp = false;
            }
        }

        if (this.tag=="player2")
        {
            if (Input.GetKey(KeyCode.D) && movimientoP2)
            {
                vectorRotacion =new Vector3(0,speed*Time.deltaTime,0);
                //this.transform.localEulerAngles = vectorRotacion;
                this.transform.Rotate(vectorRotacion,Space.Self);
            }
           
            if (Input.GetKey(KeyCode.A) && movimientoP2)
            {
                vectorRotacion = -new Vector3(0,speed*Time.deltaTime,0);
                //this.transform.localEulerAngles = vectorRotacion;
                this.transform.Rotate(vectorRotacion,Space.Self);
            }

            if (Input.GetKey(KeyCode.W) && movimientoP2)
            {
                Vector3 direction = (transform.forward * 1).normalized;
                rigidbody.velocity = direction * movementSpeed;

                Animator.SetTrigger("CaminarDiko");
                Animator.ResetTrigger("IdleDiko");
                walking = true;
            }
            else
            {

                Animator.SetTrigger("IdleDiko");
                Animator.ResetTrigger("CaminarDiko");
                walking = false;
            }

            if (Input.GetKey(KeyCode.S) && movimientoP2)
            {
                Vector3 direction = (transform.forward * -1).normalized;
                rigidbody.velocity = direction * movementSpeed;
            }
            if (GameObject.Find("GameManager").GetComponent<gameManager>().tp2)
            {
                transform.position = pastCheckpoint2;
                GameObject.Find("GameManager").GetComponent<gameManager>().tp2 = false;
            }
        }
    }
}

