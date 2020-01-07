using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRaycast : MonoBehaviour
{
    public float range = 20.0f;
    public Camera fpsCam;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    public void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //Debug.Log(hit.transform.name);
            hit.transform.SendMessage("HitByRay", SendMessageOptions.DontRequireReceiver);
        }
    }
}
