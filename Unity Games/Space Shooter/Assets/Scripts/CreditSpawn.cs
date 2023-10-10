using System.Collections;
using System.Collections.Generic;
using System.Threading;
using static UnityEngine.Random;
using UnityEngine;

public class CreditSpawn : MonoBehaviour
{

    public Transform creditSpawn;
    public GameObject credit;
    public float rangex; // How far left or right the credit can spawn
    public float spawnDelay;
    public float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnCredit", spawnDelay, spawnInterval); // spawn credits in intervals
    }

    void spawnCredit() // Spawns a credit
    {
        float rndx = Random.Range(-rangex, rangex); // Random left or right
        Instantiate(credit, new Vector3(rndx, creditSpawn.transform.position.y, creditSpawn.transform.position.z), creditSpawn.transform.rotation); // spawn credit
    }
}
