using UnityEngine;

public class CubeAudio : MonoBehaviour
{
    [SerializeField] private AudioSource cubeSource;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            cubeSource.pitch = 0.6f;
            cubeSource.Play();
        }
    }

}
