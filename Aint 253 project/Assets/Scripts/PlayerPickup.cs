using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public Transform theDest;
    public AudioClip pickedUp;
    public AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("held item").transform;
        audio.PlayOneShot(pickedUp, 0.6f);

    }

    public void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        new Vector3(0,0,0);
    }
}
