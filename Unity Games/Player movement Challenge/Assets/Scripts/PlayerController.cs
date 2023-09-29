using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float moveSpeed;
    [SerializeField] public float mouseSensitivity;
    [SerializeField] public int jumpForce;
    [SerializeField] public int gravity;
    [SerializeField] public float sprintMult;
    [SerializeField] public float crouchMult;
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
        float horizontalRot = Input.GetAxis("Mouse X"); //get mouse rotation
        float horizontal = Input.GetAxis("Horizontal"); //get left or right
        float vertical = Input.GetAxis("Vertical"); // get up or down
        moveDirection = new Vector3(horizontal, 0.0f, vertical);
        moveDirection = (moveDirection / 100) * moveSpeed; // Set Speed
        
        if (Input.GetKey(KeyCode.Z))
        {
            // Is couching
            moveDirection = moveDirection * crouchMult;
            gameObject.transform.localScale = new Vector3(.5f, .5f, .5f);

        } else if (Input.GetKey(KeyCode.LeftShift))
        {
            // Is Sprinting
            moveDirection = moveDirection * sprintMult;
            gameObject.transform.localScale = new Vector3(1, 1, 1);

        } else
        {
            // Is Neither
            gameObject.transform.localScale = new Vector3(1, 1, 1);

        }
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
        
        transform.Rotate(0, horizontalRot * mouseSensitivity, 0); // rotate
        controller.Move(moveDirection); //move
        
        
    }
}
