using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;
    public int life, powerupspeed;
    private void Awake() {
        if(instancia == null)
        {
           instancia = this;
           DontDestroyOnLoad(gameObject);
    
           powerupspeed = 2 ;

        } else{
            Destroy(gameObject);
        }
    }
}
