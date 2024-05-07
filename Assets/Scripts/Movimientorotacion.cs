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
    public bool movimientoP1=true;
    public bool movimientoP2=true;

    void Start()
    {
        vectorRotacion = this.transform.localEulerAngles;
        rigidbody = GetComponent<Rigidbody>();

        
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

            if (Input.GetKey(KeyCode.M))
            {
                movimientoP1 = true;
            }
        }

        if(this.tag=="player2")
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
            if (Input.GetKeyDown(KeyCode.E))
            {

                movimientoP2 = true;
            }
        }
    }
}

