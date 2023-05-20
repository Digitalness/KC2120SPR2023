using UnityEngine;

public class MicrophoneExample : MonoBehaviour
{
    // Start recording with built-in Microphone and play the recorded audio right away
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        //audioSource.clip = Microphone.Start("Built-in Microphone", true, 10, 44100);
        audioSource.clip = Microphone.Start(null, true, 1, 44100);
        audioSource.Play();
    }
}