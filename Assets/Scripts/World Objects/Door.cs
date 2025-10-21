using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isDoorUnlocked;

    [SerializeField] private AudioSource doorSound;
    [SerializeField] private Animator doorAnimator;

    private void OnTriggerEnter(Collider other)
    {
       OpenDoor();
    }

    private void OnTriggerExit(Collider other)
    {
        CloseDoor();
    }

    public void OpenDoor()
    {
        if (isDoorUnlocked)
        {
            doorAnimator.SetBool("IsOpen", true);
            doorSound.pitch = 1f;
            doorSound.Play();
        }
    }

    public void CloseDoor()
    {
        if (!isDoorUnlocked)
        {
            doorAnimator.SetBool("IsOpen", false);
            doorSound.pitch = 1.1f;
            doorSound.Play();
        }
    }

    public void UnlockDoor(bool unlocked)
    {
        isDoorUnlocked = unlocked;
    }

    private void Update()
    {
       
    }

}
