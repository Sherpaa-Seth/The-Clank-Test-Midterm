using UnityEngine;

public class ChaseNPCState : NPCState
{
    public Transform targetToChase;

    public override void OnStateEnter()
    {
        Debug.Log("Player Detected!");
    }

    public override void OnStateExit()
    {
        
    }

    public override void OnStateRun()
    {
        character.SetAgentDestination(targetToChase.position);
    }

    public ChaseNPCState(CharacterAI owner) : base(owner)
    {

    }

}
