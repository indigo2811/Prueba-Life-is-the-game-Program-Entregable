using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public Transform CharacterPos;
    public float mouseSensitivity = 5f;
    float cameraVerticalRot = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ///Mouse Inputs
        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        ///CameraRot

        cameraVerticalRot -= inputY;
        cameraVerticalRot = Mathf.Clamp(cameraVerticalRot, -90f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRot;


        CharacterPos.Rotate(Vector3.up * inputX);
    }
}
