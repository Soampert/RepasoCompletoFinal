using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Rigidbody enemyRigidbody;
    private GameObject Player;
    [SerializeField] private float speed = 2;

    private float minHeight = 0;


    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 direction = Player.transform.position - transform.position.normalized;
        enemyRigidbody.AddForce(direction * speed);

        if (transform.position.y <= minHeight)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}