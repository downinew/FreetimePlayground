using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    //Public to be changed 
    public float mouseSensitivity = 15.0f;
    public float playerSpeed = 50.0f;
    public float playerJumpStrength = 10.0f;

    //Private to keep the same
    private CharacterController playerController;
	private float horizontalRotation = 0f;
    private Transform playerTransform;
    private float forwardSpeed;
    private float sideSpeed;
    private Vector3 speed;
    private float fallingSpeed = 0f;

	// Use this for initialization
	void Start () {
        playerController = GetComponent<CharacterController>();
        playerTransform = GetComponent<Transform>();
        Screen.lockCursor = true;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


        //Rotation of the player
		horizontalRotation = Input.GetAxis("Mouse X") * mouseSensitivity;
        playerTransform.Rotate(0, horizontalRotation, 0);


        //Speed and movement of Character
        forwardSpeed = Input.GetAxis("Vertical") * playerSpeed;
        sideSpeed = Input.GetAxis("Horizontal") * playerSpeed;
        fallingSpeed += Physics.gravity.y * Time.deltaTime;
        if (Input.GetButtonDown("Jump") && playerController.isGrounded)
        {
            fallingSpeed = playerJumpStrength;
        }
        speed = new Vector3(sideSpeed, fallingSpeed, forwardSpeed);
        speed = playerTransform.rotation * speed;
        playerController.Move(speed * Time.deltaTime);

  
        
	}
}
