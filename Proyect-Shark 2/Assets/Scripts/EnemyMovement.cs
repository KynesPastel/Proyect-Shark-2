using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    // Start is called before the first frame update

    private GameObject player;
    void Start()
    {
        player = GameObject.Find("SharkV1");
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
        MoveTowards();
      
    }

    private void MoveTowards()
    {
        Vector3 direction = (player.transform.position - transform.position);
        if (direction.magnitude > 3)
        {
            transform.position += speed * direction.normalized * Time.deltaTime;
        }
    }

    private void LookAtPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = newRotation;
    }
}
