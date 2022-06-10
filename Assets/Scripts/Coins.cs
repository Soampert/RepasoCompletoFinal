using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class Coins : MonoBehaviour
{
    //CollectedCoins CollectedCoins;

    // public Rigidbody coinRigidbody;
    // public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

        //CollectedCoins = GameObject.FindGameObjectWithTag("Player").GetComponent<CollectedCoins>();
        /*
        coinRigidbody = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (transform.position.y <= minHeight)
        {
            Destroy(gameObject);
        }
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // CollectedCoins.InshallahCoins = CollectedCoins.InshallahCoins + 1;
            Destroy(gameObject);
        }
    }




    /*
    private void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Money"))
        {
            // StartCoroutine(CoinCountDown());
            Destroy(otherCollider.gameObject);
        }
    }
    */

}
