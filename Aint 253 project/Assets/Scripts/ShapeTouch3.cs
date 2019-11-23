using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeTouch3 : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent PanelPress;
    // Start is called before the first frame update

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "shape slot 3")
        {
            PanelPress.Invoke();
            Debug.Log("touching2");
        }
    }
}
