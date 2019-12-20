using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public Transform theDest;

    public AudioClip pickedUp;
    public AudioSource audio;

    private bool isheld = false;
    //public Collider collider;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (isheld == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
    public void OnMouseDown()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        //collider.enabled = false;
        this.transform.parent = GameObject.Find("held item").transform;
        audio.PlayOneShot(pickedUp, 0.6f);

    }

    public void OnMouseUp()
    {
        this.transform.parent = null;
        //collider.enabled = true;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
        new Vector3(0,0,0);
    }
}
