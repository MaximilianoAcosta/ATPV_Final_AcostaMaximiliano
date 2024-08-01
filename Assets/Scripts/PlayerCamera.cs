using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] float MouseSensitivity;
    [SerializeField] Transform CameraTransform;
    Vector2 look;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        look.x += Input.GetAxis("Mouse X")* MouseSensitivity;
        look.y += Input.GetAxis("Mouse Y") * MouseSensitivity;
        look.y = Mathf.Clamp(look.y, -89f, 89f);
        
        CameraTransform.localRotation = Quaternion.Euler(-look.y, 0, 0);
        transform.localRotation = Quaternion.Euler(0, look.x, 0);
    }
}
