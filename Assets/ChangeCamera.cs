using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeCamera : MonoBehaviour
{

    // Define global variables
    public Camera FirstPerson;
    public Camera ThirdPerson;
    public Camera SceneCamera;

    private Camera[] cameras;
    private int currCameraIndex = 2;
    private Camera currCamera;
    private string camLabel;

    // Start is called before the first frame update
    void Start()
    {
        // Disable unused cameras
        FirstPerson.enabled = false;
        ThirdPerson.enabled = false;
        // Initialize array of cameras to cycle through
        cameras = new Camera[] {FirstPerson, ThirdPerson, SceneCamera};
        currCamera = SceneCamera;
    }

    public void ChangeCam() 
    {
        // Move to next camera in array
        currCameraIndex++;

        // Circle back to beginning
        if (currCameraIndex > 2) {
            currCameraIndex = 0;
        }

        // Disable current camera
        currCamera.enabled = false;

        // Change active camera
        currCamera = cameras[currCameraIndex];

        // Enable new camera
        currCamera.enabled = true;
    }    
}


