using Unity.VisualScripting;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private bool isGrounded;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private AudioSource walkingSound;
    [SerializeField] private AudioSource sprintSound;

    [SerializeField] private AudioSource shootSound;
    [SerializeField] private Animator shootAnim;

    private void Update()
    {
        isGrounded = Physics.CheckSphere(controller.transform.position, 0.2f, groundLayer);

        if (Input.GetMouseButtonDown(0))
        {
            shootSound.Play();
            shootAnim.Play("GunShoot", -1, 0f);
        }

        if (!isGrounded)
        {
            walkingSound.enabled = false;
            sprintSound.enabled = false;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                walkingSound.enabled = false;
                sprintSound.enabled = true;
            }
            else
            {
                walkingSound.enabled = true;
                sprintSound.enabled = false;
            }
        }
        else
        {
            walkingSound.enabled = false;
            sprintSound.enabled = false;
        }
    }



}
