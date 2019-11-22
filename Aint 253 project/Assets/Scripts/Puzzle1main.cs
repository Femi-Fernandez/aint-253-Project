using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puzzle1main : MonoBehaviour
{
    public int button_1_count = 0;
    public int button_2_count = 0;
    public int button_3_count = 0;

    public bool puzzleComplete = false;
    public Text puzzleCompleteText;

    private void Start()
    {
        puzzleCompleteText.text = "";
    }
    public void button1Press()
    {
        button_1_count++;
    }
    public void button2Press()
    {
        button_2_count++;
    }
    public void button3Press()
    {
        button_3_count++;
    }

    public void puzzleCompleteCheck()
    {
        if ((button_1_count == 2)&&(button_2_count == 3)&&(button_3_count==5))
        {
            puzzleComplete = true;
            puzzleCompleteText.text = "Puzzle complete!";
        }
        else
        {
            button_1_count = 0;
            button_2_count = 0;
            button_3_count = 0;
        }
    }
}
