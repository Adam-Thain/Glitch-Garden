using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField] Slider volumeSlider;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] float defaultVolume = 0.8f;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] Slider difficultySlider;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] float defaultDifficulty = 0.8f;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        //
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();

        //
        difficultySlider.value = PlayerPrefsController.GetDifficulty();
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
        PlayerPrefsController.SetDifficulty(volumeSlider.value);

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

        //
        difficultySlider.value = defaultDifficulty;
    }
}
