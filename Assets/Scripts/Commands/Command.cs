using UnityEngine;

public abstract class Command : MonoBehaviour
{
    public CharacterCompanion characterTarget;

    public abstract bool IsComplete();
    public abstract void Execute();
    public abstract void Cancel();

}
