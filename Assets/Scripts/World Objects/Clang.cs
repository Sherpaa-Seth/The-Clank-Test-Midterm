using UnityEngine;

public class Clang : MonoBehaviour
{
    [SerializeField] private AudioSource audioClang;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            audioClang.pitch = Random.Range(0.95f, 1.05f);
            audioClang.Play();
        }
    }
}
