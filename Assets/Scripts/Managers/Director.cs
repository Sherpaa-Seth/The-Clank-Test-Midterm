using UnityEngine;
using UnityEngine.Playables;

public class Director : MonoBehaviour
{
    [SerializeField] private PlayableDirector director;

    void Awake()
    {
        if (director != null)
        {
            director.Play();
        }
    }

}
