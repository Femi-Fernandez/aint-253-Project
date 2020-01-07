using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitCheck : MonoBehaviour
{

    public GameObject puzzle3;

    public Image blackFade;
    public GameObject player;
    public AudioClip unlock;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HitByRay()
    {
        if (puzzle3.GetComponent<Puzzle3main>().puzzle3Complete == true)
        {
            blackFade.GetComponent<Animator>().enabled = true;
            audio.PlayOneShot(unlock, 1);
            blackFade.GetComponent<Animator>().Play("fade_to_black");
        }

    }
}
