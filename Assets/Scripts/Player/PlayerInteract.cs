using System.Transactions;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private Transform eyeOrigin;
    [SerializeField] private LayerMask interactionLayer;

    private IInteractable currentInteraction;

    void Start()
    {
        
    }
    
    void Update()
    {
        Debug.DrawRay(eyeOrigin.position, eyeOrigin.forward * 4f);

        RaycastHit hitInfo;

        IInteractable interactable = null;

        if (Physics.Raycast(eyeOrigin.position, eyeOrigin.forward, out hitInfo, 4f, interactionLayer))
        {
            interactable = hitInfo.collider.GetComponent<IInteractable>();

            if (interactable != null)
            {
                currentInteraction = interactable;
                interactable.OnInteractionHoverEnter();
            }
        }

        if (interactable == null)
        {
            if(currentInteraction != null)
            {
                currentInteraction.OnInteractionHoverExit();
            }

            currentInteraction = null;
        }
       

        if (Input.GetKeyDown(KeyCode.E) && currentInteraction != null)
        {
            if (currentInteraction is CubeGrab cube)
            {
                cube.SetGrabPointOrigin(eyeOrigin);
            }

            currentInteraction.OnInteract();
        }

    }
}
