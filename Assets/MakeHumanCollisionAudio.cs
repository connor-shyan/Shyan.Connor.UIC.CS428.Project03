using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeHumanCollisionAudio : MonoBehaviour
{
    public AudioClip augh;
    public AudioSource source;
    
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.playOnAwake = false;
        source.clip = augh;
    }


    private void OnCollisionEnter()
    {
        if (!source.isPlaying)
        {
            source.Play();
        }
    }
}
