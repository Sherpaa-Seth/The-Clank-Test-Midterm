using UnityEngine;

public class IdleNPCState : NPCState
{
    private float timer = 0;

    public override void OnStateEnter()
    {
        Debug.Log("Start Idle");
        timer = Random.Range(2f, 4f);
    }

    public override void OnStateExit()
    {
        Debug.Log("Not Idle Anymore");
    }

    public override void OnStateRun()
    {
        Debug.Log("Waiting For Command");
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            character.ChangeState(new WanderNPCState(character));
        }
    }

    public IdleNPCState(CharacterAI owner) : base(owner)
    {

    }
}
