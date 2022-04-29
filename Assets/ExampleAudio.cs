using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleAudio : MonoBehaviour
{
    AudioSource audioSource;
    AudioClip audioClip;

    void Start(){
        // Will load Resources/Audio/Soundtrack
        audioClip = (AudioClip)Resources.Load("Audio/Soundtrack");
        audioSource.clip = audioClip;
        if(!audioSource.isPlaying) audioSource.Play();
    }
}
