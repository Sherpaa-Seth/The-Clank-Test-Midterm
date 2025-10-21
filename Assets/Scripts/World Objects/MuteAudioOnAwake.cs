using UnityEngine;

public class MuteAudioOnAwake : MonoBehaviour
{
    
    void Awake()
    {
        AudioListener listener = GetComponent<AudioListener>();
        AudioListener.volume = 0f;
    }

    private void Start()
    {
        Invoke("OnStartUnmute", 0.5f);
    }

    public void OnStartUnmute()
    {
        AudioListener.volume = 1f;
    }
}
