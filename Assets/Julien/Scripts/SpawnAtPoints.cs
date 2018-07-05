using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAtPoints : MonoBehaviour
{

    public Transform[] spawnLocation;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    private void Start()
    {

        spawnSomething();

    }

    void spawnSomething()
    {

        whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocation[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[1], spawnLocation[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        whatToSpawnClone[2] = Instantiate(whatToSpawnPrefab[2], spawnLocation[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;

    }

}
