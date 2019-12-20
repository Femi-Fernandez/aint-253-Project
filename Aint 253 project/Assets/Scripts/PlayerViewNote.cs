using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerViewNote : MonoBehaviour
{
    public Image note1;
    public bool viewingNote;
    public Text noteText;
    int notenumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        viewingNote = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1") && !viewingNote)
        {
            note1.GetComponent<Animator>().Play("Note_1_view");
            notenumber = 1;
            StartCoroutine(toggleBool(notenumber));       
            //Debug.Log("here 1 ");


        }
        if ((Input.GetKeyDown("1")) && viewingNote)
        {
            note1.GetComponent<Animator>().Play("Note_1_return");
            notenumber = 0;
            StartCoroutine(toggleBool(notenumber));
            //noteText.text = "";
            //Debug.Log("here 2 ");

        }
    }

    IEnumerator toggleBool(int notenum) {
        if (notenum == 0)
        {
            noteText.text = "";
        }
        yield return new WaitForSecondsRealtime(1);
        viewingNote = !viewingNote;
        
        if (notenum == 1)
        {
            noteText.text = "note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, note goes here, blah blah blah, ";
        }
    }
}
