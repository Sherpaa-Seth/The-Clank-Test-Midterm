using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterJump : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private bool isGrounded;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private Vector3 currentVelocity;
    [SerializeField] private Vector3 gravityAcceleration;
    [SerializeField] private Vector3 jumpForce;

    [SerializeField] private AudioSource jumpSound;
    
    void Update()
    {
        if (isGrounded == false)
        {
            currentVelocity += gravityAcceleration * Time.deltaTime;

            if (currentVelocity.y < -10f)
            {
                currentVelocity.y = -10f;
            }
        }
        if (isGrounded == true)
        {
            if (currentVelocity.y < 0)
            {
                currentVelocity.y = 0;
            }
        }

        controller.Move(currentVelocity * Time.deltaTime);

        isGrounded = Physics.CheckSphere(controller.transform.position, 0.2f, groundLayer);

    }

    public void Jump()
    {
        if (isGrounded)
        {
            jumpSound.Play();
            currentVelocity = jumpForce;
            isGrounded = false;
        }

    }

}
