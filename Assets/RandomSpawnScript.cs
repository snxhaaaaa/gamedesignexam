﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnScript : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefab4;

    public float spawnRate = 3f;

    float nextSpawn = 0f;

    int whatToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            //Destroy(gameObject);
            whatToSpawn = Random.Range(1, 5);
            Debug.Log(whatToSpawn);
            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(prefab2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(prefab3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(prefab4, transform.position, Quaternion.identity);
                    break;
            }

            nextSpawn = Time.time + spawnRate;
        }
        
    }

}
