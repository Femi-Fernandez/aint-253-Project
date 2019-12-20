using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 6.0f;
    private float gravity = -9f;
    private float jumpSpeed = 10f;
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
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        charCont.Move(movement);

        if (charCont.isGrounded == true && charCont.velocity.magnitude > 3 && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().Play();
        }
    }

        //float deltaX = Input.GetAxis("Horizontal") * speed;
        //float deltaZ = Input.GetAxis("Vertical") * speed;
        //
        //    movement = new Vector3(deltaX, 0, deltaZ);
        //    movement = Vector3.ClampMagnitude(movement, speed);
        //    movement = transform.TransformDirection(movement);
        //
        //
        //    //if (Input.GetButtonDown("Jump"))
        //    //{
        //    //    movement.y = jumpSpeed;
        //    //    //Debug.Log("here");
        //    //}
        //
        //movement.y -= gravity;
        //
        //charCont.Move(movement * Time.deltaTime);
    
}
