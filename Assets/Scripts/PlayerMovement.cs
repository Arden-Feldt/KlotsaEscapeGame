using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private CharacterController controller;

    public float speed  = 12f;
    public float gravity = -9.81f *2;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = .4f;
    public LayerMask groundMask;
    
    Vector3 velocity;

    bool isGrounded;
    bool isMoving;

    private Vector3 lastPosition = new Vector3(0f,0f,0f);

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // ground check
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        // Reseting the default velocity
        if (isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }

        // Get inputs
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        // move the character
        controller.Move(move * speed * Time.deltaTime);

        // check if jump
        if (Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // Falling down
        velocity.y += gravity * Time.deltaTime;

        // Execute the jump
        controller.Move(velocity * Time.deltaTime);

        // For later use
        if (lastPosition != gameObject.transform.position && isGrounded == true){
            isMoving = true;
        } else {
            isMoving = false;
        }

        lastPosition = gameObject.transform.position;
    }
}
