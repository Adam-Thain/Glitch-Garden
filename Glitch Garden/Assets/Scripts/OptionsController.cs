using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    public Slider volumeSlider, diffSlider;

    /// <summary>
    /// 
    /// </summary>
    public LevelManager levelManager;

    /// <summary>
    /// 
    /// </summary>
    private MusicManager musicManager;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    public void Start () {

        // Get music manager gameobject
        musicManager = GameObject.FindObjectOfType<MusicManager>();

        //
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();

        //
        diffSlider.value = PlayerPrefsManager.GetDifficulty();
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    public void Update () {

        if(musicManager)
        {
            musicManager.SetVolume(volumeSlider.value);
        }
        else
        {
            return;
        }

	}

    /// <summary>
    /// 
    /// </summary>
    public void SaveAndExit()
    {
        //
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);

        //
        PlayerPrefsManager.SetDifficulty(diffSlider.value);

        //
        levelManager.LoadLevel("01 Start Menu");
    }

    /// <summary>
    /// 
    /// </summary>
    public void SetDefaults()
    {
        //
        volumeSlider.value = 0.8f;

        //
        diffSlider.value = 2f;
    }
}
