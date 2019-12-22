using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3ChangeLetter : MonoBehaviour
{
    public Sprite[] letterList;
    public GameObject letterDisplay;
    private Texture2D currentLetter;
    public int letterCount;
    // Start is called before the first frame update
    void Start()
    {
        letterCount = 0;   
    }

    public void pressDown()
    {
        letterCount++;
        if (letterCount == 26)
        {
            letterCount = 0;
        }
    }
    public void pressUp()
    {
        letterCount--;
        if (letterCount == -1)
        {
            letterCount = 25;
        }
    }
    // Update is called once per frame
    void Update()
    {
        letterDisplay.GetComponent<SpriteRenderer>().sprite = letterList[letterCount];
    }
}
