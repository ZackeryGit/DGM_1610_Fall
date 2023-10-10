using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float speed;
    public int inventory;
    public float xRange;
    private float horizontalInput;
    public Transform blaster;
    public GameObject lazerBolt;


    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetMouseButtonDown(0) && Time.timeScale != 0)
        {
            // Create Lazer Bolt at Blaster
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);

        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Credit"))
        {
            inventory += 1;
            Debug.Log("Credits: " + inventory);
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Lazer"))
        {
            Destroy(other.gameObject);
        }
        
    }    
}
