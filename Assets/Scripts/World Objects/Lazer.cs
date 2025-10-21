using UnityEngine;

public class Lazer : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameManager gameManager;

    [SerializeField] private AudioSource lazerSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lazerSound.Play();
            animator.Play("Damaged");
            gameManager.DisableInput.Invoke();
            Invoke("StopTheGame", 1f);
        }
    }

    public void StopTheGame()
    {
        gameManager.StopGame();
    }

}
