using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    [SerializeField] float defaultVolume = 0.8f;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        //
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        //
        var musicPlayer = FindObjectOfType<MusicPlayer>();

        // IF
        // ELSE
        if (musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No music player found, start from splash screen?");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void SaveAndExit()
    {
        //
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);

        //
        FindObjectOfType<LevelLoader>().LoadMainMenu();
    }

    /// <summary>
    /// 
    /// </summary>
    public void SetDefaults()
    {
        //
        volumeSlider.value = defaultVolume;
    }
}
