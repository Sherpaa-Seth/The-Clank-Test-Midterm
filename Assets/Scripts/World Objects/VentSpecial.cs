using UnityEngine;

public class VentSpecial : MonoBehaviour
{
    public Animator specialWallAnim;

    [SerializeField] private GameObject specialWall;

    [SerializeField] private AudioSource audioClang;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            specialWall.SetActive(false);
            
            audioClang.pitch = 1f;
            audioClang.Play();
        }
    }

}
