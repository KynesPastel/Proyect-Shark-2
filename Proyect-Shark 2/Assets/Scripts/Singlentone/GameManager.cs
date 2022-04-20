using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{
    public static GameManager instancia;
    public int life, speed, lastSP;
    
    private void Awake() {
        if(instancia == null)
        {
           instancia = this;
           DontDestroyOnLoad(gameObject);
        life = 100;
           speed = 2 ;
           
    
        } else{
            Destroy(gameObject);
        }
    }
}
