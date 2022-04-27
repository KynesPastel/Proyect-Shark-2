using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerCollision : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
       /* if (other.gameObject.CompareTag("Healing"))
        {
            Debug.Log(name + " TRIGGER CON " + other.gameObject.name);
            Destroy(other.gameObject);
            lifePlayer = lifePlayer + 20;
            GameManager.instancia.powerupspeed++;

        }*/

       /* if (other.gameObject.CompareTag("Savepoint"))
        {
            Debug.Log(other.name);
            SavePointManager managerSP = other.transform.parent.GetComponent<SavePointManager>();
            managerSP.FindSavePoint(other.name);
        }

      /*  if (other.gameObject.CompareTag("Trash"))
        {
            GameObject trash = other.gameObject;
            trash.SetActive(false);
            GetComponent<InventoryManager>().AddInventoryOne(trash);
        }*/

    }

}
