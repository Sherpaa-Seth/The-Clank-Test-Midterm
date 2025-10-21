using UnityEngine;

public class WanderNPCState : NPCState
{

    public override void OnStateEnter()
    {
        character.SetAgentDestination( new Vector3 (Random.Range(-10, 10), 0, Random.Range(-10, 10) ));
    }

    public override void OnStateExit()
    {
        
    }

    public override void OnStateRun()
    {
        if (!character.IsMoving())
        {
            character.ChangeState(new IdleNPCState(character));
        }
    }

    public WanderNPCState(CharacterAI owner) : base(owner)
    {

    }
}
