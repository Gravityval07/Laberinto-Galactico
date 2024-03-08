using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PuertaDestruir : MonoBehaviour
{

    public GameObject PanelPP1;
    private void OnTriggerEnter(Collider other)
    {

        PanelPP1.SetActive(true);

        
    }
    void update ()
    {

            if (Input.GetKey(KeyCode.K))
            {
                PanelPP1.SetActive(false);
                Destroy(gameObject);
            }
        
    }

}