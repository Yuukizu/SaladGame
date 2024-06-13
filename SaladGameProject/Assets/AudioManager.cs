using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   


    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clip")]
    [SerializeField]private AudioClip BG;
    [SerializeField] private AudioClip ClickSound;
    [SerializeField] private AudioClip ServeSFX;
    [SerializeField] private AudioClip gethitSFX;


    public AudioClip _clickSound=>ClickSound;
    public AudioClip _serveSound => ServeSFX;
    public AudioClip _gethitSound => gethitSFX;

    public void Start()
    {
        musicSource.clip = BG;
        musicSource.Play();

    }


    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}

