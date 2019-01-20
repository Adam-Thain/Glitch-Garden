using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    private MusicManager musicManager;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {

        //
        musicManager = GameObject.FindObjectOfType<MusicManager>();

        // IF
        // ELSE 
        if(musicManager)
        {
            //
            Debug.Log("Found music manager " + musicManager);

            //
            float volume = PlayerPrefsManager.GetMasterVolume();

            //
            musicManager.SetVolume(volume);
        }
        else
        {
            Debug.LogWarning("No music manager found in start scene, no volume set");
        }
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
	
	}
}
