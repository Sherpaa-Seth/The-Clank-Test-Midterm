using UnityEngine;

public class Lift : MonoBehaviour
{
    [SerializeField] string playerTag = "Player";
    [SerializeField] private Transform platform;

    [SerializeField] private Animator liftAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            other.gameObject.transform.parent = platform;
            liftAnimator.SetBool("PlayerEntered", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            other.gameObject.transform.parent = null;
            liftAnimator.SetBool("PlayerEntered", false);
        }
    }

}
