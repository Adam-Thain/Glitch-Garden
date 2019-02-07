using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GamerTimer : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    public float levelSeconds = 100;

    /// <summary>
    /// 
    /// </summary>
    private Slider slider;

    /// <summary>
    /// 
    /// </summary>
    private AudioSource audioSource;

    /// <summary>
    /// 
    /// </summary>
    private bool isEndOfLevel;

    /// <summary>
    /// 
    /// </summary>
    private LevelManager levelManager;

    /// <summary>
    /// 
    /// </summary>
    private GameObject winLabel;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {

        //
        slider = GetComponent<Slider>();

        //
        audioSource = GetComponent<AudioSource>();

        //
        levelManager = GameObject.FindObjectOfType<LevelManager>();

        //
        FindYouWin();

        //
        winLabel.SetActive(false);
	}

    /// <summary>
    /// 
    /// </summary>
    void FindYouWin()
    {
        winLabel = GameObject.Find("You Win");
        if (!winLabel)
        {
            Debug.LogWarning("Plase create you win object");
        }
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {

        //
        slider.value = Time.timeSinceLevelLoad / levelSeconds;

        //
        bool timeIsUp = (Time.timeSinceLevelLoad >= levelSeconds);

        //
        if (timeIsUp && !isEndOfLevel)
        {
            audioSource.Play();
            winLabel.SetActive(true);
            Invoke("LoadNextLevel", audioSource.clip.length);
            isEndOfLevel = true;
        }
	}

    /// <summary>
    /// 
    /// </summary>
    void LoadNextLevel()
    {
        levelManager.LoadNextLevel();
    }
}
