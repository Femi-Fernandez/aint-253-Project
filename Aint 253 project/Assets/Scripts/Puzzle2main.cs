using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2main : MonoBehaviour
{

    public bool panel1Press = false;
    public bool panel2Press = false;
    public bool panel3Press = false;
    public bool puzzle2Complete = false;

    //public GameObject hole1;
    //public GameObject hole2;
    //public GameObject hole3;
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
        Debug.Log("boom");
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
