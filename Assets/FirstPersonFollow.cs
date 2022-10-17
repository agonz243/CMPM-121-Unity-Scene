using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonFollow : MonoBehaviour
{
    public float turnSpeed = 4.0f;
    public float moveSpeed = 2.0f;
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 90.0f;
    private float rotX;
    Vector3 Vec;

    void Update ()
    {
        MouseAiming();
        KeyboardMovement();
    }
    void MouseAiming ()
    {
        // get the mouse inputs
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;
        // clamp the vertical rotation
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);
        // rotate the camera
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
    }
    void KeyboardMovement ()
    {
        Vec = transform.localPosition;  
        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 20;  
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;  
        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 20;  
        transform.localPosition = Vec; 
    }
}
