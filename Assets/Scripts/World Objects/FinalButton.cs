using UnityEngine;
using UnityEngine.Events;

public class FinalButton : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject whiteCanvas;
    [SerializeField] private AudioSource whooshAudio;

    [SerializeField] private Animator buttonAnimator;
    [SerializeField] private AudioSource buttonSound;

    [SerializeField] private MeshRenderer buttonRenderer;
    [SerializeField] private Material hoverEnterMat;
    [SerializeField] private Material hoverExitMat;

    [SerializeField] private UnityEvent OnButtonPress;

    public void OnInteract()
    {
        buttonSound.Play();
        
        OnButtonPress.Invoke();

        buttonAnimator.SetBool("IsPressed", true);
        whooshAudio.time = 0.15f;
        whooshAudio.Play();
        whiteCanvas.SetActive(true);
    }

    public void OnInteractionHoverEnter()
    {
        buttonRenderer.material = hoverEnterMat;
    }

    public void OnInteractionHoverExit()
    {
        buttonRenderer.material = hoverExitMat;
    }

}
