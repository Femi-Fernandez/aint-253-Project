using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickupObject : MonoBehaviour
{
    GameObject mainCamera;
    bool carrying;
    public float distance;
    public float smooth;
    GameObject carriedObject;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (carrying)
        {
            carry(carriedObject);
            checkDrop();
        }
        else {
            pickup();
          }      
    }

    void dropObject()
    {
        carrying = false;
        carriedObject.GetComponent<Rigidbody>().isKinematic = false;
        //carriedObject.GetComponent<Rigidbody>().useGravity = true;
        carriedObject = null;   
    }

    void checkDrop()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            dropObject();
        }
    }

    void carry(GameObject o)
    {

        o.transform.position = Vector3.Lerp(o.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime* smooth);
        o.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    void pickup()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, 20f))
            {
                Debug.Log(hit.transform.name);
                Pickupable p = hit.collider.GetComponent<Pickupable>();
                if (p != null)
                {
                    carriedObject = p.gameObject;
                    carrying = true;                  
                    p.GetComponent<Rigidbody>().isKinematic = true;
                    p.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                }
            }
        }
    }
    
}
