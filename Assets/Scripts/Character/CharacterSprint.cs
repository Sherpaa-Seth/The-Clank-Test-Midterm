using UnityEngine;

public class CharacterSprint : MonoBehaviour
{
    [SerializeField] private CharacterMovement movement;

    [SerializeField] private float speed = 2;
 
    public void StartSprinting()
    {
        movement.SetMoveSpeed(speed);
    }
    
    public void StopSprinting()
    {
        movement.SetMoveSpeed(-speed);
    }
}
