using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] asteroidPrefabs;

    public float startTimeBtwSpawns;
    private float timeBetweenSpawns;
    public float timeToAdd;
    public float timeToGoneAsteroid;
    private GameObject theClone;


    // Start is called before the first frame update
    void Start()
    {
        timeBetweenSpawns = startTimeBtwSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenSpawns <= 0)
        {

            int randAsteroid = Random.Range(0, asteroidPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            theClone = Instantiate(asteroidPrefabs[0], spawnPoints[randSpawnPoint].position, transform.rotation);
            Destroy(theClone, 3);
            timeBetweenSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBetweenSpawns -= (float)(Time.deltaTime+timeToAdd);
        }
    }
}
