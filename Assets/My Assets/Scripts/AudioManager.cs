using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource RocketEngineAudio;
    public AudioSource AmbienceAudio;

    // Start is called before the first frame update
    void Start()
    {
        RocketEngineAudio.Stop();
        AmbienceAudio.Play();
    }

    public void SwitchToRocketAudio()
    {
        RocketEngineAudio.Play();
        AmbienceAudio.Stop();
    }
}
