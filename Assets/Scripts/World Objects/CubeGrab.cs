using UnityEngine;

public class CubeGrab : MonoBehaviour, IInteractable
{
    [SerializeField] private Rigidbody cubeRigidbody;

    [SerializeField] private Transform grabPoint;
    private bool isGrabbed;

    public void OnInteract()
    {
        if (isGrabbed == true)
        {
            isGrabbed = false;
            cubeRigidbody.isKinematic = false;

            cubeRigidbody.transform.SetParent(null);
        }
        else
        {
            isGrabbed = true;
            cubeRigidbody.isKinematic = true;

            cubeRigidbody.transform.SetParent(grabPoint);
            
            cubeRigidbody.transform.position = grabPoint.position + (grabPoint.forward * 2.5f);
            cubeRigidbody.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }


    public void SetGrabPointOrigin(Transform point)
    {
        grabPoint = point;
    }

    public void OnInteractionHoverEnter()
    {
        
    }

    public void OnInteractionHoverExit()
    {
       
    }

}
