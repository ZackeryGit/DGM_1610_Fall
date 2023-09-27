using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float moveSpeed;
    [SerializeField] public int jumpForce;
    [SerializeField] public int gravity;
    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontal, 0.0f, vertical);
        moveDirection = (moveDirection / 100) * moveSpeed;
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            isJumping = true;
        }
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);
        if (isJumping)
        {
            moveDirection.y = jumpForce;
            isJumping = false;
        }
        controller.Move(moveDirection);
    }
}
