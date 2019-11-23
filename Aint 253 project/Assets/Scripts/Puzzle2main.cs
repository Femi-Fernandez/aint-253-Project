using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2main : MonoBehaviour
{

    private bool panel1Press = false;
    private bool panel2Press = false;
    private bool panel3Press = false;
    private bool puzzle2Complete = false;
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
    }
    public void panel2Pressed()
    {
        panel2Press = true;
    }
    public void panel3Pressed()
    {
        panel3Press = true;
    }
    
    public void puzzleCheck()
    {
        if ((panel1Press = true)&&(panel2Press = true)&&(panel3Press = true))
        {
            puzzle2Complete = true;
            Debug.Log("puzzle 2 complete!");
        }
     
    }
}
