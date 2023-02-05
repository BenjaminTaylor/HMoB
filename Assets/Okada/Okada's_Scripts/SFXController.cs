using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  This is a script to manage sound(BGM,SEÅEÅEÅEetc.)without Singleton-Monobehaviour 
/// </summary>
public class SFXController
{
    /// <summary>Variable for SFXController's instance</summary>
    static SFXController instance;

    AudioSource _audioSource;

    SFXController() 
    {
        GameObject sfxControllerObj = new GameObject("SFXController");

        _audioSource = sfxControllerObj.AddComponent<AudioSource>();

        Object.DontDestroyOnLoad(sfxControllerObj);
    }

    public static SFXController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SFXController();
            }
            return instance;
        }
    }

    public void PlaySound(AudioClip clip)
    {
        _audioSource.clip = clip;

        _audioSource.Play();
    }
}
