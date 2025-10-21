using UnityEngine;
using UnityEngine.Events;

public class TimeTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent OnGameStart;

    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !hasTriggered)
        {
            OnGameStart.Invoke();

            hasTriggered = true;
        }

    }

}
