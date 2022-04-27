using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class META : MonoBehaviour

{
    

[SerializeField] private Text textComplete;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision) { 
        if (collision.gameObject.tag == "Bola"){ 
            textComplete.gameObject.SetActive(true);
            } 

      

    }
}
