using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefabs; // Array for enemy prefabs [0,1,2]
    public int enemyRange; // How far left & right an enemy can spawn
    public int enemyDist; // How far back do the enemies spawn
    public float startDelay; // How long until enemies start to spawn
    public float spawnInterval; // How long between enemy spawns

    void Start()
    {

        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval); // Spawn enemy in intervals
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        int randomLocationx = Random.Range(-enemyRange, enemyRange); 
        int enemyIndex = Random.Range(0,enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], new Vector3(randomLocationx,.5f, enemyDist), enemyPrefabs[enemyIndex].transform.rotation);
    }
}
