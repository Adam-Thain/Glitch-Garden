﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    const string MASTER_VOLUME_KEY = "master volume";

    /// <summary>
    /// 
    /// </summary>
    const string DIFFICULTY_KEY = "difficulty";

    /// <summary>
    /// 
    /// </summary>
    const float MIN_VOLUME = 0f;

    /// <summary>
    /// 
    /// </summary>
    const float MAX_VOLUME = 1f;

    /// <summary>
    /// 
    /// </summary>
    const float MIN_DIFFICULTY = 0f;

    /// <summary>
    /// 
    /// </summary>
    const float MAX_DIFFICULTY = 2f;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="volume"></param>
    public static void SetMasterVolume(float volume)
    {
        // IF
        // ELSE
        if(volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            //
            Debug.Log("Master volume set to " + volume);

            //
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            //
            Debug.LogError("Master volume is out of range");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static float GetMasterVolume()
    {
        //
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="difficulty"></param>
    public static void SetDifficulty(float difficulty)
    {
        // IF
        // ELSE
        if(difficulty >= MIN_DIFFICULTY && difficulty <= MAX_DIFFICULTY)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Difficulty is not in range");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static float GetDifficulty()
    {
        //
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
}
