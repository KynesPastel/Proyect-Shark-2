using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{/*
    [SerializeField] protected float speed = 2f;
    [SerializeField] int HP = 1;

    [SerializeField] float rangeAttack = 10f;
*/
 [SerializeField] protected EnemyData enemyStats;
    private GameObject player;
   
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("SharkV1");
    }

    // Update is called once per frame
    void Update()
    {
        Move();



    }
    protected virtual void Move()
    {
        Vector3 direction = (player.transform.position - transform.position);
        if (direction.magnitude > 3)
        {
            transform.position += enemyStats.speed * direction.normalized * Time.deltaTime;
        }



    }
}
