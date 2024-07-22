using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    float xRotation =  0f;
    float yRotation = 0f;

    public float topClamp = -90f;
    public float bottomClamp = 90f;

    // Start is called before the first frame update
    void Start()
    {
        // lock cursor to middle of screen and make invis
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        // gettting mouse inputs
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotaition aroud the x axis (look up and down)
        xRotation -= mouseY;

        // Clamp Rotaion
        xRotation = Mathf.Clamp(xRotation, topClamp, bottomClamp);

        // Rotation left and right
        yRotation += mouseX;

        // Apply rotations to our transform
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
