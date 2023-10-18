using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{

    public ScoreManager scoreManager; // Store reference to scoreManager
    public GameObject explosionPrefab;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find score manager script
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Lazer") && other.CompareTag("Enemy"))  // If object is a lazer, and hits an enemy
        {
            Instantiate(explosionPrefab, other.transform.position, other.transform.rotation); // create a explosion audio, that deletes once its done playing (See Explosion Audio Script)
            scoreManager.IncreaseScore(10);
            Destroy(gameObject); // Destroy bullet
            Destroy(other.gameObject); // Destroy Enemy
        }
        if (this.CompareTag("Player") && other.CompareTag("Credit"))
        {
            scoreManager.IncreaseCredits(1);
            Destroy(other.gameObject); // Destroy Credit
        }
    }
}
