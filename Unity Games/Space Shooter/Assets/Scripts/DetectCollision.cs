using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Lazer") && other.CompareTag("Enemy"))  // If object is a lazer, and hits an enemy
        {
            Destroy(gameObject); // Destroy bullet
            Destroy(other.gameObject); // Destroy Enemy
        }
    }
}
