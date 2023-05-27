using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
     public float _sensX;
     public float _sensY;

     public Transform orientation;
     private float yRotation;
     private float xRotation;

     private void Start()
     {
          Cursor.lockState = CursorLockMode.Locked;
          Cursor.visible = false;
     }

     private void Update()
     {
          float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * _sensX;
          float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * _sensY;

          yRotation += mouseX;

          xRotation -= mouseY;
          xRotation = Mathf.Clamp(xRotation, -90f, 90f);
          
          orientation.rotation = Quaternion.Euler(0, yRotation,0);
          
     }
}
