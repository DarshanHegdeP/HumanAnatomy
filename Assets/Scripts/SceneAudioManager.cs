// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class SceneAudioManager : MonoBehaviour
// {
//     public AudioSource audioSource;
//     public float delayBeforePlay = 5f;
//     public float maxDuration = 60f;

//     private void Start()
//     {
//         if (audioSource != null && audioSource.clip != null)
//         {
//             Invoke(nameof(StartAudio), delayBeforePlay);
//         }

//         // Stop audio when scene changes
//         SceneManager.sceneUnloaded += OnSceneUnloaded;
//     }

//     void StartAudio()
//     {
//         if (!audioSource.isPlaying)
//         {
//             audioSource.Play();
//             Invoke(nameof(StopAudio), maxDuration);
//         }
//     }

//     void StopAudio()
//     {
//         if (audioSource.isPlaying)
//         {
//             audioSource.Stop();
//         }
//     }

//     void OnSceneUnloaded(Scene current)
//     {
//         StopAudio();
//         CancelInvoke(); // cancel any pending StartAudio or StopAudio
//     }

//     private void OnDestroy()
//     {
//         SceneManager.sceneUnloaded -= OnSceneUnloaded;
//     }
// }
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public float delayBeforePlay = 5f;
    public float maxDuration = 60f;

    private bool isTriggered = false;

    private void Start()
    {
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }

    public void PlayAudioDelayed()
    {
        if (audioSource != null && audioSource.clip != null && !isTriggered)
        {
            isTriggered = true;
            Invoke(nameof(StartAudio), delayBeforePlay);
        }
    }

    void StartAudio()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
            Invoke(nameof(StopAudio), maxDuration);
        }
    }

    void StopAudio()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }

    void OnSceneUnloaded(Scene current)
    {
        StopAudio();
        CancelInvoke();
    }

    private void OnDestroy()
    {
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }
}
