using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    //variables for player movement
    public float speed = 1.0f;
    public float jumpForce = 1.0f;
    public float gravity = 1.0f;
    private Vector3 moveDir = Vector3.zero;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void FixedUpdate() {
        //Player movement
        CharacterController controller = gameObject.GetComponent<CharacterController>();

        if (controller.isGrounded) {
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDir = Vector3.ClampMagnitude(moveDir, 1);
            moveDir = transform.TransformDirection(moveDir);
            moveDir = moveDir * speed;

            if (Input.GetButtonDown("Jump")) {
                moveDir.y = jumpForce;
            }
        }

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir);
    }
}

