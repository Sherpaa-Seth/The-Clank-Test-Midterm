using UnityEngine;
using UnityEngine.AI;

public class EnemyAnimation : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Animator animator;

    void Update()
    {
        animator.SetFloat("Velocity", agent.velocity.magnitude);

        if (agent.velocity.magnitude > 0.01f)
        {

        }
        else if (agent.velocity.magnitude < 0.01f)
        {

        }
    }
}
