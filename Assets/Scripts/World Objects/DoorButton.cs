using UnityEngine;

public class DoorButton : MonoBehaviour, IInteractable
{
    [SerializeField] private Door doorReference;

    [SerializeField] private Animator buttonAnimator;
    [SerializeField] private AudioSource buttonSound;
   
  
    [SerializeField] private MeshRenderer buttonRenderer;
    [SerializeField] private Material hoverEnterMat;
    [SerializeField] private Material hoverExitMat;

    public void OnInteract()
    {
        buttonSound.Play();
        buttonAnimator.SetBool("IsPressed", true);
        doorReference.isDoorUnlocked = true;
        doorReference.OpenDoor();
    }

    public void OnInteractionHoverEnter()
    {
        Debug.Log("Press E to interact");
        buttonRenderer.material = hoverEnterMat;
    }

    public void OnInteractionHoverExit()
    {
        buttonRenderer.material = hoverExitMat;
    }

}
