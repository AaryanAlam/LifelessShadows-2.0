using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPmovement : MonoBehaviour
{
   public float speed = 5f;
    public float jumpSpeed = 5f;
    public float gravity = -9.81f;
    public float crouchHeight = 1f;
    public float lookSensitivity = 2f;
    private float _originalHeight;

    private CharacterController _controller;
    public Transform _camera;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _originalHeight = _controller.height;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        Vector3 move = transform.right * x + transform.forward * z;

        _controller.Move(move * speed * Time.deltaTime);

        if (_controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            _controller.Move(Vector3.up * jumpSpeed * Time.deltaTime);
        }

        _controller.Move(Vector3.up * gravity * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftControl))
        {
            _controller.height = crouchHeight;
            speed = 2.5f;
        }
        else
        {
            _controller.height = _originalHeight;
            speed = 5;
        }


        // first-person look
        float mouseX = Input.GetAxis("Mouse X") * lookSensitivity;
        mouseX = Mathf.Clamp(mouseX, -20f, 70f);
        float mouseY = Input.GetAxis("Mouse Y") * lookSensitivity;

        transform.Rotate(0f, mouseX, 0f);

        float newXRotation = _camera.localEulerAngles.x - mouseY;
        if (newXRotation > 180f)
        {
            newXRotation -= 360f;
        }

        newXRotation = Mathf.Clamp(newXRotation, -20f, 80f);

        _camera.localEulerAngles = new Vector3(
            newXRotation,
            0f,
            0f
        );
    }
}
