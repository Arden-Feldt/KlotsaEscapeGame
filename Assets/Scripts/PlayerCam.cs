using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    float xRotation =  0f;
    float yRotation = 0f;

    public Transform orientation;
    public float topClamp = -90f;
    public float bottomClamp = 90f;

    // Start is called before the first frame update
    void Start()
    {
        // lock cursor to middle of screen and make invis
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // gettting mouse inputs
        float mouseX = Input.GetAxisRaw("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotaition aroud the x axis (look up and down)
        xRotation -= mouseY;

        // Rotation left and right
        yRotation += mouseX;

        // Clamp Rotaion
        xRotation = Mathf.Clamp(xRotation, topClamp, bottomClamp);

        // Apply rotations to our transform
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
