using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 2f;

    public static event Action OnDeath;
    private CharacterController ccShark;
    private float cameraAxisX;
    private float cameraAxisY;
    public float lifePlayer = 100;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = FindObjectOfType<SavePointManager>().GetSavePoint(GameManager.instancia.lastSP).position;

        PlayerMovement.OnDeath += GameOverBehavior;

        ccShark = GetComponent<CharacterController>();
    }

    // Update is called once per frame


    void Update()
    {
        RotateShark();
        Move();





        //SceneManager.LoadScene("Level");

        /*
        if (Input.GetKeyDown(KeyCode.G)) {
            GameObject trash = GetComponent<InventoryManager>().GetInventoryOne();
            trash.SetActive(true);
        }*/



    


    }
    //FUERZA
    private void MoveShark(Vector3 directionShark)
    {
        transform.Translate(speed * Time.deltaTime * directionShark);
    }
    //ROTACION EN VERTICAL Y HORIZONTAL
    private void RotateShark()
    {
        cameraAxisX += Input.GetAxisRaw("Mouse X");
        cameraAxisY += Input.GetAxisRaw("Mouse Y");



        Quaternion angulo = Quaternion.Euler(0f, cameraAxisX, cameraAxisY);
        transform.localRotation = angulo;
    }
    /* 
         
  */
    //DESACTIVAR RIGIDBODY EN  TRY AGAIN
    public void GameOverBehavior()
    {
        GetComponent<Rigidbody>().isKinematic = true;

        this.enabled = false;
    }
    //COMER  PARA CURARSE
    //public void Healing()
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Healing"))
        {
            Debug.Log(name + " TRIGGER CON " + other.gameObject.name);
            Destroy(other.gameObject);
            lifePlayer = lifePlayer + 20;
            GameManager.instancia.speed++;

        }
            //SAVEPOINT RETURN
        if (other.gameObject.CompareTag("Savepoint"))
        {
            Debug.Log(other.name);
            SavePointManager managerSP = other.transform.parent.GetComponent<SavePointManager>();
            managerSP.FindSavePoint(other.name);
        }
    }

    //MOVIMIENTO AWSD
    private void Move()
    {   //PRESS S
        if (Input.GetKey(KeyCode.S))
        {
            MoveShark(Vector3.right);
        }
        //PRESS W
        if (Input.GetKey(KeyCode.W))
        {
            MoveShark(Vector3.left);
        }
        //PRESS A
        if (Input.GetKey(KeyCode.A))
        {
            MoveShark(Vector3.back);

        }
        //PRESS D
        if (Input.GetKey(KeyCode.D))
        {
            MoveShark(Vector3.forward);

        }

    }



}
