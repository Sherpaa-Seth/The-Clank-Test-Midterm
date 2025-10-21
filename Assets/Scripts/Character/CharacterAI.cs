using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.XR.Haptics;

public class CharacterAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent myAgent;
    //[SerializeField] private Transform target;
    [SerializeField] private AudioSource audioSource;

    //Vector3 lastPosition;
    private NPCState CurrentState;

    public void Start()
    {
        ChangeState(new WanderNPCState(this));
    }

    public void ChangeState(NPCState newState)
    {
        if (CurrentState != null)
        {
            CurrentState.OnStateExit();
        }

        CurrentState = newState;

        CurrentState.OnStateEnter();
    }

    void Update()
    {
        if (CurrentState != null)
        {
            CurrentState.OnStateRun();
        }

        if (myAgent.velocity.magnitude < 0.4f)
        {
            audioSource.volume = 0f;
        }
        else if (myAgent.velocity.magnitude > 0.4f)
        {
            audioSource.volume = 0.04f;
        }

    }

    public bool IsMoving()
    {
        return myAgent.remainingDistance > myAgent.stoppingDistance && myAgent.velocity.magnitude > 0.5f;
    }

    public void SetAgentDestination(Vector3 destination)
    {
        myAgent.SetDestination(destination);
    }

    //IEnumerator FindPathCoroutine()
    //{
    //    while (true)
    //    {
    //        myAgent.SetDestination(target.position);
    //        yield return new WaitForSeconds(2f);
    //    }
    //}

}
