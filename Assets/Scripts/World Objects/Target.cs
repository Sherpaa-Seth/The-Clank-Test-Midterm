using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private AudioSource targetAudio;

    [SerializeField] private Animator wall;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            targetAudio.Play();
            wall.SetBool("TargetHit", true);
        }

    }

}
