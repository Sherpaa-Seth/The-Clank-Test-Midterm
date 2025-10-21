using UnityEngine;

public class CubeAudioFloorHitScript : MonoBehaviour
{
    [SerializeField] private AudioSource cubeSource;

    private void OnCollisionEnter(Collision floor)
    {
        if (floor.gameObject.CompareTag("Floor"))
        {
            cubeSource.pitch = 0.2f;
            cubeSource.Play();
        }
    }
}
