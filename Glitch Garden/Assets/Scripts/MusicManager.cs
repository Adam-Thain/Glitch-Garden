using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

    #region Private Members

    /// <summary>
    /// Audio Source Holder
    /// </summary>
    private AudioSource audioSource;

    #endregion

    #region Public Members

    /// <summary>
    /// Array of music change audio clips
    /// </summary>
    public AudioClip[] levelMusicChangeArray;

    #endregion

    #region Public Methods

    /// <summary>
    /// When the game starts
    /// </summary>
    public void Awake()
    {
        // Do not destroy this object when the game starts
        DontDestroyOnLoad(gameObject);

        Debug.Log("Dont destroy on load: " + name);
    }

    /// <summary>
    /// Use this for initialization
    /// </summary>
    public void Start()
    {
        // Get the audio source component 
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// When the level or scene is loaded
    /// </summary>
    /// <param name="level"> Current level </param>
    public void OnLevelWasLoaded(int level)
    {
        // Get the music based on the current level or scene
        AudioClip thisLevelMusic = levelMusicChangeArray[level];

        Debug.Log("Playing Clip: " + thisLevelMusic);

        // If there is music attached
        if (thisLevelMusic)
        {
            // Set the audio source clip to this level music
            audioSource.clip = thisLevelMusic;

            // Loop the audio source
            audioSource.loop = true;

            // Play the audio source
            audioSource.Play();
        }
    }

    #endregion
}
