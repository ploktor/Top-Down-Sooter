﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGC : MonoBehaviour
{
    public GameObject gameController;
    public Transform[] spawnSpots;
    private float timeBtwnSpawns;
    public float startTimeBtwnSpawns;

    public int maxEnemies = 1;
    int enemyCounter = 0;





    // Start is called before the first frame update
    void Start()
    {
        timeBtwnSpawns = startTimeBtwnSpawns;
               
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwnSpawns <= 0 && enemyCounter < maxEnemies)
        {
            int randPos = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(gameController, spawnSpots[randPos].position, Quaternion.identity);
            timeBtwnSpawns = startTimeBtwnSpawns;
            enemyCounter++;
        }
        else
        {
            timeBtwnSpawns -= Time.deltaTime;
        }


    }
}
