using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Almejas : MonoBehaviour
{
    [SerializeField] private GameObject shootOrigen;
    [SerializeField] private int shootColdown = 2;
    [SerializeField] private float timeShoot = 2;
    private bool canShoot = true;


    [SerializeField] private GameObject pearlPrefab;
    [SerializeField] private float distanceRay = 10f;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot)
        {
            emitirRaycast();
        }
        else
        {
            timeShoot += Time.deltaTime;
        }
        if (timeShoot > shootColdown)
        {
            canShoot = true;
        }
    }

    private void emitirRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(shootOrigen.transform.position, shootOrigen.transform.TransformDirection(Vector3.forward), out hit, distanceRay))
        {
            if (hit.transform.tag == "Player")
            {
                canShoot = false;
                timeShoot = 0;
                GameObject b = Instantiate(pearlPrefab, shootOrigen.transform.position, pearlPrefab.transform.rotation);
                b.GetComponent<Rigidbody>().AddForce(shootOrigen.transform.TransformDirection(Vector3.forward) * 10f, ForceMode.Impulse);
            }
        }
    }
    private void OnDrawGizmos()
    {





        if (canShoot)
        {
            Gizmos.color = Color.cyan;
            Vector3 puntob = shootOrigen.transform.TransformDirection(Vector3.forward) * distanceRay;
            Gizmos.DrawRay(shootOrigen.transform.position, puntob);

        }
    }

}
