using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditMove : MonoBehaviour
{

    public float bottomBounds; 
    public float speed;
    public Material material1;
    public Material material2;
    public int currentMat = 1;
    public float flickerSpeed;
    public float flickerDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("creditFlicker", flickerDelay, flickerSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); // Move credit down screen
        if (transform.position.z < bottomBounds) // Delete credit if uncollected and off screen
        {
            Destroy(gameObject);
        }
    }

    void creditFlicker()
    {
        if (currentMat == 1)
        {
            gameObject.GetComponent<Renderer>().material = material2;
            currentMat = 2;
        } else if (currentMat == 2)
        {
            gameObject.GetComponent<Renderer>().material = material1;
            currentMat = 1;
        }
    }
}
