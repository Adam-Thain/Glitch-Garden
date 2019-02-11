﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class LevelLoader : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] int timeToWait = 4;

    /// <summary>
    /// 
    /// </summary>
    int currentSceneIndex;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    private void Start () {

        // Get build index
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // IF
        if(currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    /// <summary>
    /// 
    /// </summary>
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}