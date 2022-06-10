using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    public float MaxHP = 100;

    public GameObject Player;
    public float speed = 10f;
    // [SerializeField] private float jumpForce = 400f;

    public bool isOnGround;

    public bool gameOver;
    
    private Rigidbody playerRigidbody;

    [SerializeField] private float jumpForce = 400f;

    private Animator playerAnimator;

    private float horizontalMove;
    public CharacterController pureya;

    public Rigidbody RigidBodyComponent;

    private AudioManager AMS;

    private void Start()
    {

        // isOnGround = true;
        gameOver = false;

        playerRigidbody = GetComponent<Rigidbody>();
        RigidBodyComponent = GetComponent<Rigidbody>();

        playerAnimator = GetComponent<Animator>();

        AMS = FindObjectOfType<AudioManager>();

        // pureya = GetComponent<CharacterController>();

        // Player = GetComponent<CharacterController>();

    }

    private void Awake()
    {

    }

    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");



        // Vector3 RbMovement = new Vector3(horizontalMove, 0, horizontalMove) * speed;
        // RbMovement = transform.TransformDirection(RbMovement);

        // playerRigidbody.AddForce(Vector3.right * speed * horizontalInput);
        // playerRigidbody.AddForce(Vector3.forward * speed * verticalInput);

        //if (Input.GetKeyDown(KeyCode.Space) && isOnGround)

        if (Input.GetButtonDown("Jump") && isOnGround)
        {
            // Indicamos
            // playerRigidbody.AddForce(Vector3.up * jumpForce);
            // Transicion

            //playerRigidbody.AddForce(new Vector3(0, 100, 0), ForceMode.Impulse);

            // playerRigidbody.velocity = new Vector3(0f, 15f, 0f);

            playerRigidbody.AddForce(Vector3.up * jumpForce);

            playerAnimator.SetTrigger("Jump_trig");

            isOnGround = false;

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                // transform.rotation = Quaternion.Euler(x: 0, y: 180, z: 0);
                // Player.transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);

            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                // transform.rotation= Quaternion.Euler(x: 0, y: 180, z: 0);
                // Player.transform.Rotate(0.0f, 45.0f, 0.0f, Space.World);

            }
        }
    }

    private void FixedUpdate()
    {
        Vector3 playerRigidbody = new Vector3(horizontalMove, 0, 0);
        RigidBodyComponent.MovePosition(RigidBodyComponent.position + playerRigidbody * speed * Time.deltaTime);

        // Vector3 RbMovement = new Vector3(horizontalMove, 0, horizontalMove) * speed;
        // playerRigidbody.MovePosition(transform.position * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            MaxHP -= 20;
            Debug.Log ("-20");
        }
    }



    private void OnCollisionEnter(Collision otherCollider)
    {
        if (!gameOver) // gameOver true false
                           // !gameOver false true
        {
            // Si colisionamos con el suelo, entonces tocamos el suelo
            if (otherCollider.gameObject.CompareTag("Ground"))
            {
                isOnGround = true;

                // Activamos el sistema de partículas de la tierra
                // dirtParticleSystem.Play();

                /*
                Instantiate(dirt, transform.position,
                dirt.transform.rotation);

                dirt.Play();
                
                Play();
                */



            }
            /*else
            {
                !isOnGround;
            }
            

            if (isOnGround == false)
            {
                dirt.Pause();
            }
            */
        }


    }
    
}

