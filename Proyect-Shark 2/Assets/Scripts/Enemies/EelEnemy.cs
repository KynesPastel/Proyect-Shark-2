using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EelEnemy : Enemy
{
  private GameObject player;
  
    
    void Start()
    {
    player = GameObject.Find("SharkV1");
    }
    protected override void Move()
    {
        LookAtPlayer();
        Vector3 direction = (player.transform.position - transform.position);
        if (direction.magnitude > 3)
        {
            transform.position += enemyStats.speed * direction.normalized * Time.deltaTime;
        }
        
    }
     private void LookAtPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = newRotation;
    }
}
