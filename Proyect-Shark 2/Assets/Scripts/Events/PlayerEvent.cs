using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerEvent : MonoBehaviour
{
    public static event Action onDeath;
    public static event Action onDamage;
    public static event Action onComplete;
    // Start is called before the first frame update
    public static void OnDeath()
    {
        onDeath?.Invoke();
    }
    public static void OnDamage(){
        onDamage?.Invoke();
    }
     public static void OnComplete(){
        onComplete?.Invoke();
    }
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
