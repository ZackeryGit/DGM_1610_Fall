using System.Collections;
using System.Collections.Generic;
using System.Threading;
using static UnityEngine.Random;
using UnityEngine;

public class CreditSpawn : MonoBehaviour
{

    public Transform creditSpawn;
    public GameObject credit;
    public float rangex;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCorutine(rangex));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnCorutine(float rangex)
    {
        WaitForSeconds waitTime = new WaitForSeconds(5);
        while (true)
        {
            float rndx = Random.Range(-rangex, rangex);
            Instantiate(credit, new Vector3(rndx, creditSpawn.transform.position.y, creditSpawn.transform.position.z), creditSpawn.transform.rotation);
            yield return waitTime;
        }
    }
}
