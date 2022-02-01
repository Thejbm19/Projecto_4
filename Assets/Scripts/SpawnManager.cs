using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    private Vector3 spawnPos = new Vector3(10, 0, 0);
    public float startDelay = 2f;
    public float repeatRate = 15f;
    public float timeDestroy = 20f;

    private float spawnPositionRange = 9f;

    void Start()
    {
        //  InvokeRepeating("SpawnObject", startDelay, repeatRate);
        //Instantiate(EnemyPrefab, spawnPos, EnemyPrefab.transform.rotation)
        SpawnEnemy();
    }

    void Update()
    {
       
    }

    public void SpawnObject()
    {
      // Instantiate(EnemyPrefab, spawnPos, EnemyPrefab.transform.rotation);
       
    }

    private Vector3 RandomSpawnPosition()
    {
        float xRandom = Random.Range(-spawnPositionRange, spawnPositionRange);
        float zRandom = Random.Range(-spawnPositionRange, spawnPositionRange);

        return new Vector3(xRandom, 0, zRandom);
    }

    private void SpawnEnemy()
    {
        Instantiate(EnemyPrefab, RandomSpawnPosition(), EnemyPrefab.transform.rotation);
    }
}
