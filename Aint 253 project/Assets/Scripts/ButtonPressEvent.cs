using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressEvent : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent ButtonPress;

    public void HitByRay()
    {
        ButtonPress.Invoke();
        Debug.Log("Ouch");
    }
}
