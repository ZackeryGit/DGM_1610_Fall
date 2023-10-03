using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float topBounds;
    public float bottomBounds;
    // Start is called before the first frame update
    private void Awake()
    {
        //Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject); 
        } else if (transform.position.z < bottomBounds)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
