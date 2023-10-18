using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float speed;
    public float xRange;
    private float horizontalInput;
    public Transform blaster;
    public GameObject lazerBolt;
    public bool alrertEnd; // Has end game alert played
    public bool gameEnded; // turns true when game manager detects end
    public AudioSource gameOverSound;

    private void Awake()
    {
        alrertEnd = false; // Has end game alert played
        gameEnded = false; // turns true when game manager detects end
    }
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
        if (gameEnded) // check if game has ended
        {
            if (alrertEnd == false) // check if game over audio played already
            {
                alrertEnd = true;
                gameOverSound.Play();
            }
        }
  
    }   
}
