using UnityEngine.InputSystem;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mousesensative = 100f;
    public Transform Player;
    float Xroration;
     void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseX = 0f;
        float mouseY = 0f;
        if(Mouse.current != null)
        {
            mouseX = Mouse.current.delta.ReadValue().x;
            mouseY = Mouse.current.delta.ReadValue().y;

        }
        if (Gamepad.current != null)
        {
            mouseX = Gamepad.current.rightStick.ReadValue().x;
            mouseY = Gamepad.current.rightStick.ReadValue().y;

        }
        mouseX *= mousesensative;
        mouseY *= mousesensative;
        Xroration -= mouseY * Time.deltaTime;
        Xroration = Mathf.Clamp(Xroration, -80, 80);
        transform.localRotation = Quaternion.Euler(Xroration, 0, 0);
        Player.Rotate(Vector3.up * mouseX * Time.deltaTime);



    }
}
