using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCamera : MonoBehaviour
{
    
    public enum RotationAxis
    {
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxis axes = RotationAxis.MouseX;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    public float sensHorizontal = 10.0f;
    public float sensVerticle = 10.0f;

    public float _rotationX = 0;


    public bool mouselocked;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        mouselocked = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (axes == RotationAxis.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensHorizontal, 0);
        }
        else if (axes == RotationAxis.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensVerticle;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && mouselocked == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            mouselocked = false;
            Debug.Log("unlock");
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && mouselocked == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            mouselocked = true;
            Debug.Log("lock");
        }

    }
}
