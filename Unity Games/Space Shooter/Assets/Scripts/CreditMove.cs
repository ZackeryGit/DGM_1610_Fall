using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditMove : MonoBehaviour
{

    public float bottomBounds; 
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
