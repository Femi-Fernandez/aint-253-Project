using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 6.0f;
    public float gravity = 5f;
    public float jumpSpeed = 0f;
    private CharacterController charCont;

    private Vector3 movement;


    // Start is called before the first frame update
    void Start()
    {
        charCont = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;

        if (charCont.isGrounded)
        {
            movement = new Vector3(deltaX, 0, deltaZ);
            movement = Vector3.ClampMagnitude(movement, speed);
            movement = transform.TransformDirection(movement);

            if (Input.GetButtonDown("Jump"))
                {
                    movement.y = jumpSpeed;
                    //Debug.Log("here");
                }

        }

        movement.y -= gravity;
        charCont.Move(movement *Time.deltaTime);
    }
}
