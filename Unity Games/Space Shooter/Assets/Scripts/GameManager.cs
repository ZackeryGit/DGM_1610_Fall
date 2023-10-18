using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool isGameOver;
    public GameObject player;
    public GameObject gameOverText;
    public PlayerMov playerMov;


    // Start is called before the first frame update
    private void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
        gameOverText.SetActive(false);
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            EndGame();
        }
    }
    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
        playerMov.gameEnded = true;
    }
}
