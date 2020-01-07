using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3main : MonoBehaviour
{
    public bool puzzle3Complete = false;
    public GameObject display1;
    public GameObject display2;
    public GameObject display3;
    public GameObject display4;
    public GameObject display5;
    public GameObject display6;
    public GameObject display7;
    public GameObject display8;
    public GameObject display9;
    public GameObject display10;
    public GameObject display11;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void puzzleCompleteCheck()
    {
        if ((display1.GetComponent<Puzzle3ChangeLetter>().letterCount == 19)
            && (display2.GetComponent<Puzzle3ChangeLetter>().letterCount == 8)
            && (display3.GetComponent<Puzzle3ChangeLetter>().letterCount == 12)
            && (display4.GetComponent<Puzzle3ChangeLetter>().letterCount == 4)
            && (display5.GetComponent<Puzzle3ChangeLetter>().letterCount == 19)
            && (display6.GetComponent<Puzzle3ChangeLetter>().letterCount == 14)
            && (display7.GetComponent<Puzzle3ChangeLetter>().letterCount == 11)
            && (display8.GetComponent<Puzzle3ChangeLetter>().letterCount == 4)
            && (display9.GetComponent<Puzzle3ChangeLetter>().letterCount == 0)
            && (display10.GetComponent<Puzzle3ChangeLetter>().letterCount == 21)
            && (display11.GetComponent<Puzzle3ChangeLetter>().letterCount == 4))
        {
            puzzle3Complete = true;
        }
    }
}
