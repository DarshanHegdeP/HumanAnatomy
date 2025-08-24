using UnityEngine;
using Vuforia;

public class PlayAudioOnImageTarget : MonoBehaviour
{
    public AudioSource audioSource;
    public float delay = 5f;

    private ObserverBehaviour observer;

    void Start()
    {
        observer = GetComponent<ObserverBehaviour>();
        if (observer)
        {
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED || targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            Invoke(nameof(PlayAudio), delay);
        }
        else
        {
            CancelInvoke(nameof(PlayAudio));
            if (audioSource && audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }

    void PlayAudio()
    {
        if (audioSource && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
