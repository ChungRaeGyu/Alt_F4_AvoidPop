using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    public AudioClip[] music = new AudioClip[10];
    AudioSource audioSource;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            RandomPlay();
        }
    }

    private void RandomPlay()
    {
        audioSource.clip = music[Random.Range(0, music.Length)];
        audioSource.Play();
    }
}
