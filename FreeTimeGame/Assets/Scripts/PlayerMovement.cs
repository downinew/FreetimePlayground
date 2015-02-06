using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private CharacterController playerController;
    public float playerSpeed = 8.0f;
    public float gravity = 9.81f;
    public float playerJumpStrength = 50.0f;

	// Use this for initialization
	void Start () {
        playerController = GetComponent<CharacterController>();

    }
	
	// Update is called once per frame
	void Update () {

        playerController.Move(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed);
        playerController.Move(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
        playerController.Move(Vector3.down * gravity * Time.deltaTime);

        
	}
}
