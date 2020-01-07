using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 6.0f;
    private float gravity = 20f;
    private float jumpSpeed = 8f;

    private CharacterController charCont;

    public GameObject puzzle2;
    
    private Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        charCont = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (charCont.isGrounded)
        {


            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (puzzle2.GetComponent<Puzzle2main>().puzzle2Complete == true)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    moveDirection.y = jumpSpeed;
                    //Debug.Log("here");
                }

            }
            
            if (charCont.velocity.magnitude > 3 && GetComponent<AudioSource>().isPlaying == false)
            {
                GetComponent<AudioSource>().Play();
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        charCont.Move(moveDirection*Time.deltaTime);
    }
        //float deltaX = Input.GetAxis("Horizontal") * speed;
        //float deltaZ = Input.GetAxis("Vertical") * speed;
        //Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        //movement = Vector3.ClampMagnitude(movement, speed);
        //
        //
        //if (charCont.isGrounded)
        //{
        //    if (Input.GetButtonDown("Jump"))
        //    {
        //        movement.y = jumpSpeed;
        //        //Debug.Log("here");
        //    }
        //}
        //movement.y = gravity * Time.deltaTime;
        //movement = transform.TransformDirection(movement);
        //charCont.Move(movement *  Time.deltaTime);
        //
        //if (charCont.isGrounded == true && charCont.velocity.magnitude > 3 && GetComponent<AudioSource>().isPlaying == false)
        //{
        //    GetComponent<AudioSource>().Play();
        //}
    

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
