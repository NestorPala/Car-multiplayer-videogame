using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_Reverse : MonoBehaviour
{
    public Camera Reverse;

    // Start is called before the first frame update
    void Start()
    {   
        try {
            Reverse.enabled = false;  
        } 
        catch (System.Exception) {
            // Arreglar camara reversa
        }
    }

    // Update is called once per frame
    void Update()
    {   
        try {
            if (Input.GetKey(KeyCode.R)) {
                Reverse.enabled = true;
            }
            else {
                Reverse.enabled = false;
            }
        } 
        catch (System.Exception){
            // Arreglar camara reversa
        }
    }
}
