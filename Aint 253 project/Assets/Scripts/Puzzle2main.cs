using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2main : MonoBehaviour
{

    public bool panel1Press = false;
    public bool panel2Press = false;
    public bool panel3Press = false;
    public bool puzzle2Complete = false;

    public AudioClip shape1;
    public AudioClip shape2;
    public AudioClip shape3;

    public AudioClip puzzle_complete;
    public AudioSource audioClips;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void panel1Pressed()
    {
        panel1Press = true;
        audioClips.PlayOneShot(shape1, .5f);
        //Debug.Log("boom");
    }
    public void panel2Pressed()
    {
        panel2Press = true;
        audioClips.PlayOneShot(shape2, .5f);
    }
    public void panel3Pressed()
    {
        panel3Press = true;
        audioClips.PlayOneShot(shape3, .5f);
    }
    
    public void puzzleCheck()
    {
        if ((panel1Press = true)&&(panel2Press = true)&&(panel3Press = true))
        {
            puzzle2Complete = true;
            audioClips.PlayOneShot(puzzle_complete, .5f);
            Debug.Log("puzzle 2 complete!");
        }
     
    }
}
