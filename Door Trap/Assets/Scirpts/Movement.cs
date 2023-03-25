using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.UI;


public class Movement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 15f;
    private Vector3 move;

    public float gravity = -10f;
    public float jumpHeight = 8f;
    private Vector3 velocity;

    public Transform groundcheck;
    public LayerMask groundLayer;
    private bool isGrounded;

    InputAction movement;
    InputAction jump;



    void Start()
    {
        jump = new InputAction("Jump", binding:"<Keyboard/space>");
        jump.AddBinding("<Gamepad/a>");
        jump = new InputAction("Puzzle", binding: "<Keyboard/P>");
        movement = new InputAction("Movement", binding: "<Gamepad/leftStick>");
        movement.AddCompositeBinding("Dpad")
            .With("Up", "<Keyboard>/w").With("Down", "<Keyboard>/s")
            .With("Left", "<Keyboard>/a").With("Right", "<Keyboard>/d")
            .With("Up", "<Keyboard>/upArrow").With("Down", "<Keyboard>/downArrow")
            .With("Left", "<Keyboard>/leftArrow").With("Right", "<Keyboard>/RightArrow");
        movement.Enable();
        jump.Enable();
       


    }
    void Update()
    {
        float x = movement.ReadValue<Vector2>().x;
        float z = movement.ReadValue<Vector2>().y;
       
       

        move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        isGrounded = Physics.CheckSphere(groundcheck.position, 0.3f, groundLayer);
        if (isGrounded==true && velocity.y < 0)
            velocity.y = -1f;
            if (isGrounded==true)
        {
            if (Mathf.Approximately(jump.ReadValue<float>(),1))
            {
                Jump();
            }
        }
        else {
            velocity.y += gravity * Time.deltaTime;
                }
        controller.Move(velocity * Time.deltaTime);
    }
   private void Jump()
    {
        velocity.y = Mathf.Sqrt(2*jumpHeight*-gravity);
    }
   
  
}
