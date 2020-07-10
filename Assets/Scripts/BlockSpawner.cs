using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] BabySpawner;
    public GameObject baby;
    private float timeToSpawn=2f;
    public float timeBetweenWaves = 1f;

    void Update()
    {
        if (Time.time >= timeToSpawn) //function to keep track of time
        {
            SpawnBabies();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void SpawnBabies()          //function to spawn baby gameobject
    {
        int SpawnerIndex = Random.Range(0, BabySpawner.Length);
        Instantiate(baby, BabySpawner[SpawnerIndex].position, Quaternion.identity);
    }
}
