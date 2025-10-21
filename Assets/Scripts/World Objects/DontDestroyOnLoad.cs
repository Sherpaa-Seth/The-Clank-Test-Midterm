using Unity.VisualScripting;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    public static DontDestroyOnLoad Singleton;

    private void Awake()
    {
        if (Singleton == null)
        {
            Singleton = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
