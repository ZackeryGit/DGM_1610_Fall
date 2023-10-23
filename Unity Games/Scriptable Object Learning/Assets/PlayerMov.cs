using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{

    public float horizontalAxis;
    public float verticalAxis;
    public PlayerData playerData ;
    public Vector2 movement;
    public float speed;
    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");
        movement = new Vector2((horizontalAxis / 10) * speed, (verticalAxis / 10) * speed);
        characterController.Move(movement);
    }

    public void UpdateSpeed()
    {
        speed = playerData.speed;
    }
}
