using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerViewNote : MonoBehaviour
{
    public Image note1;
    public Image note2;
    public Image note3;
    public bool viewingNote1;
    public bool viewingNote2;
    public bool viewingNote3;
    public Text noteText;
    public Text noteIndicator1;
    public Text noteIndicator2;
    public Text noteIndicator3;

    public int notenumber = 0;

    public GameObject puzzle1;
    public GameObject puzzle2;
    public GameObject puzzle3;

    public bool isPlaying;
    public AudioClip viewNote;
    public AudioSource audioClips;
    // Start is called before the first frame update
    void Start()
    {
        viewingNote1 = false;
        viewingNote2 = false;
        viewingNote3 = false;

        noteIndicator1.enabled = false;
        noteIndicator2.enabled = false;
        noteIndicator3.enabled = false;

        note1.enabled = false;
        note2.enabled = false;
        note3.enabled = false;

        isPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzle1.GetComponent<Puzzle1main>().puzzleComplete == true)
        {
            note1.enabled = true;
            noteIndicator1.enabled = true;
            if (Input.GetKeyDown("1") && isPlaying == false && (!viewingNote1 && !viewingNote2 && !viewingNote2))
            {
                note1.GetComponent<Animator>().Play("Note_1_view");
                notenumber = 1;
                isPlaying = true;
                audioClips.PlayOneShot(viewNote, .5f);
                StartCoroutine(toggleBool(notenumber));
            }

            if ((Input.GetKeyDown("1")) && isPlaying == false && (viewingNote1 && !viewingNote2 && !viewingNote3))
            {
                note1.GetComponent<Animator>().Play("Note_1_return");
                notenumber = 0;
                isPlaying = true;
                audioClips.PlayOneShot(viewNote, .5f);
                StartCoroutine(toggleBool(notenumber));
            }
        }

        if (puzzle2.GetComponent<Puzzle2main>().puzzle2Complete == true)
        {
            note2.enabled = true;
            noteIndicator2.enabled = true;
            if (Input.GetKeyDown("2") && isPlaying == false && (!viewingNote1 && !viewingNote2 && !viewingNote3))
            {
                note2.GetComponent<Animator>().Play("Note_2_view");
                notenumber = 2;
                isPlaying = true;
                audioClips.PlayOneShot(viewNote, .5f);
                StartCoroutine(toggleBool(notenumber));
            }
            if ((Input.GetKeyDown("2")) && isPlaying == false && (!viewingNote1 && viewingNote2 && !viewingNote3))
            {
                note2.GetComponent<Animator>().Play("Note_2_return");
                notenumber = 0;
                isPlaying = true;
                audioClips.PlayOneShot(viewNote, .5f);
                StartCoroutine(toggleBool(notenumber));
            }
        }


        if (puzzle3.GetComponent<Puzzle3main>().puzzle3Complete == true)
        {
            note3.enabled = true;
            noteIndicator3.enabled = true;
            if (Input.GetKeyDown("3") && isPlaying == false && (!viewingNote1 && !viewingNote2 && !viewingNote3))
            {
                note3.GetComponent<Animator>().Play("Note_3_view");
                notenumber = 3;
                isPlaying = true;
                audioClips.PlayOneShot(viewNote, .5f);
                StartCoroutine(toggleBool(notenumber));
            }
            if ((Input.GetKeyDown("3")) && isPlaying == false && (!viewingNote1 && !viewingNote2 && viewingNote3))
            {
                note3.GetComponent<Animator>().Play("Note_3_return");
                notenumber = 0;
                isPlaying = true;
                audioClips.PlayOneShot(viewNote, .5f);
                StartCoroutine(toggleBool(notenumber));
            }
        }

    }

    IEnumerator toggleBool(int notenum) {

        noteText.text = "";
        yield return new WaitForSecondsRealtime(1);

        if (notenum == 0)
        {
            
            if (viewingNote1)
            {
                viewingNote1 = !viewingNote1;
                isPlaying = false;
            }
            if (viewingNote2)
            {
                viewingNote2 = !viewingNote2;
                isPlaying = false;
            }
            if (viewingNote3)
            {
                viewingNote3 = !viewingNote3;
                isPlaying = false;
            }
        }
        if (notenum == 1)
        {
            viewingNote1 = !viewingNote1;
            isPlaying = false;
            noteText.text = "note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, ";
        }
        if (notenum == 2)
        {
            viewingNote2 = !viewingNote2;
            isPlaying = false;
            noteText.text = "THIS IS NOTWE 2 THIS IS NOTWE 2 THIS IS NOTWE 2 THIS IS NOTWE 2 THIS IS NOTWE 2 THIS IS NOTWE 2 THIS IS NOTWE 2 THIS IS NOTWE 2 THIS IS NOTWE 2 THIS IS NOTWE 2 THIS IS NOTWE 2 THIS IS NOTWE 2 THIS IS NOTWE 2 THIS IS NOTWE 2   ";
        }
        if (notenum == 3)
        {
            viewingNote3 = !viewingNote3;
            isPlaying = false;
            noteText.text = "NOTE 3 NOTE 3 NOTE 3 NOTE 3 NOTE 3 NOTE 3  NOTE 3 NOTE 3 NOTE 3  NOTE 3 NOTE 3 NOTE 3  NOTE 3 NOTE 3 NOTE 3  NOTE 3 NOTE 3 NOTE 3  NOTE 3 NOTE 3 NOTE 3  NOTE 3 NOTE 3 NOTE 3  NOTE 3 NOTE 3 NOTE 3  NOTE 3 NOTE 3 NOTE 3  NOTE 3 NOTE 3 NOTE 3";
        }
    }
}
