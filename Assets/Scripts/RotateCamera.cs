using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField]private float rotationSpeed = 30;
  
   
    void Update()
    {
       // float horizontalInputMouse = Input.GetAxis("Mouse X");  // Moure camera amb mouse
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * horizontalInput);
    }
}
