using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public float spawnRangeXLeft;
    public float spawnRangeXRight;
    public float spawnPosZ;
    private float startDelay = 2;
    private float spawnInterval = 3f;



    // Start is called before the first frame update
    void Start()
    {
        //randomly spawn animals on timer
        InvokeRepeating("SpawnRandomAsteroid", startDelay, Random.Range(2, 4));
    }

    void SpawnRandomAsteroid()
    {
        // randomly generate asteroid index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeXLeft, spawnRangeXRight), 0, spawnPosZ);
        int asteroidIndex = Random.Range(0, asteroidPrefabs.Length);
        Instantiate(asteroidPrefabs[asteroidIndex], spawnPos,
            transform.localRotation);
       
    }
}
