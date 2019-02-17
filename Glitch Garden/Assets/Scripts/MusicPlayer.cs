using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        //
        DontDestroyOnLoad(this);

        //
        audioSource = GetComponent<AudioSource>();

        //
        audioSource.volume = PlayerPrefsController.GetMasterVolume();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="volume"></param>
    public void SetVolume(float volume)
    {
        //
        audioSource.volume = volume;
    }
}
