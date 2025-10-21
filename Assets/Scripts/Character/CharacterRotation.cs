using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    [SerializeField] private Transform head;

    [SerializeField] private Vector3 currentRotation;

    public void RotatingByAngles(Vector3 angles)
    {
        currentRotation.x += angles.x;
        currentRotation.y += angles.y;

        currentRotation.x = Mathf.Clamp (currentRotation.x, -69f, 79f);

        transform.rotation = Quaternion.Euler (0, currentRotation.y, 0);
        head.localRotation = Quaternion.Euler (-currentRotation.x, 0, 0);
    }

}
