using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour
{
    public AudioClip objectPickup;
    public AudioClip objectDrop;
    public AudioSource audioClips;
    // Start is called before the first frame update

    private void Start()
    {
        
    }
    public void playPickup() {
        audioClips.PlayOneShot(objectPickup, 1);
    }
    public void playDrop()
    {
        audioClips.PlayOneShot(objectDrop, 1);
    }
}
