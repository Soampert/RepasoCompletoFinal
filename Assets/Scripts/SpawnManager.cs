using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public Vector3 spawnPosition;

    private float minX = -34;
    private float maxX = 34;

    public float startDelay = 1f;
    public float repeatRate = 1f;

    public GameObject Enemy;

    private PlayerController playerControllerScript;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBomb", startDelay, repeatRate);
    }

    private void Update()
    {

    }


    public Vector3 RandomSpawnPosition()
    {
        float xRandom = Random.Range(minX, maxX);
        return new Vector3(xRandom, 60, 6);
    }

    void SpawnBomb()
    {

        spawnPosition = RandomSpawnPosition();
        Instantiate(Enemy, RandomSpawnPosition(), transform.rotation);

    }
    

}