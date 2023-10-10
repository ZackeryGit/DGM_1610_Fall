using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
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
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        if (transform.position.z < bottomBounds) // If enemy gets past, end game
        {
            Destroy(gameObject);
            Debug.Log("Enemy got past! Game OVER! YAAA!");
            Time.timeScale = 0;
        }
    }
}
