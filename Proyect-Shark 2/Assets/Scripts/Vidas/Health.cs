using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Health : PlayerMovement
{
    public Text Vida;
   
    [SerializeField] float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { Vida.text = lifePlayer.ToString("#,##")+ "%" ;
        if (lifePlayer <= lifePlayer - 0.02f)
        {
            Vida.text = (Convert.ToInt32(lifePlayer <= lifePlayer - 0.02f)).ToString() + "%";
        }
        
        //COMER  PARA CURARSE
        //SI EL TIBURON COME, TE CURAS
        //if 
        {
            
           
           // Vida.text = (Convert.ToInt32(lifePlayer = lifePlayer + 20)).ToString() + "%";
          

        }
        //PERDIDA CONSTANTE DE VIDA
        if (lifePlayer > 0)
        {

            lifePlayer = lifePlayer - 0.02f;
            Debug.Log("EAT, IM DYING");

        }
        //VIDA MUY BAJA
        if (lifePlayer < 15)
        {
            Debug.Log("MUST EAT");
            PlayerEvent.OnDamage();
            speed = speed + 0.2f;

        }
        //MUERTE
        if (lifePlayer < 1)
        { //we need to heal with object

            Debug.Log("TRY AGAIN");
            //OnDeath?.Invoke();
            PlayerEvent.OnDeath();
            Destroy(this);
    }
    
    
}
}
