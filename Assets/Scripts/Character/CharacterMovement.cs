using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float moveSpeed;

    public void MoveCharacter(Vector3 direction)
    {
        
        Vector3 forwardOrBackward = transform.forward * moveSpeed * direction.z;
        Vector3 leftOrRight = transform.right * moveSpeed * direction.x;

        Vector3 sumOfDirections = forwardOrBackward + leftOrRight;

        controller.Move(sumOfDirections * Time.deltaTime); 
    }

    public void SetMoveSpeed(float newSpeed)
    {
        moveSpeed += newSpeed;
    }

}
