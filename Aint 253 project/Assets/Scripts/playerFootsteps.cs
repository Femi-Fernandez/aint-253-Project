﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFootsteps : MonoBehaviour
{
    CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 3 && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
