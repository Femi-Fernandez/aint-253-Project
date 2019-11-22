using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressEvent : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent ButtonPress;
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
        ButtonPress.Invoke();
        Debug.Log("Ouch");
    }
}
