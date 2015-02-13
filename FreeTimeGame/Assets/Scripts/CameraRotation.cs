using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

    //Public for access
    public float mouseSensitivity = 15.0f;

    //Private for exclusive
    private Camera playerCamera;
    private float verticalRotation = 0f;
    private float topNeckRange = 75f;
    private float bottomNeckRange = -80f;



	// Use this for initialization
	void Start () {
        playerCamera = GetComponentInChildren<Camera>();
	}
	
	// Update the Camera
	void Update () {
        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, bottomNeckRange, topNeckRange);
        playerCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

	}
}
