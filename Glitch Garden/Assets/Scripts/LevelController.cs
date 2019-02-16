using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField] float waitToLoad = 4f;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] GameObject winLabel;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] GameObject loseLabel;

    /// <summary>
    /// 
    /// </summary>
    int numberOfAttackers = 0;

    /// <summary>
    /// 
    /// </summary>
    bool levelTimerFinished = false;

    /// <summary>
    /// 
    /// </summary>
    private void Start () {

        //
        winLabel.SetActive(false);

        //
        loseLabel.SetActive(false);
    }

    /// <summary>
    /// 
    /// </summary>
    public void AttackerSpawned()
    {
        //
        numberOfAttackers++;
    }

    /// <summary>
    /// 
    /// </summary>
    public void AttackerKilled()
    {
        //
        numberOfAttackers--;

        // IF
        if (numberOfAttackers <= 0 && levelTimerFinished)
        {
            //
            StartCoroutine(HandleWinCondition());
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    IEnumerator HandleWinCondition()
    {
        //
        winLabel.SetActive(true);

        //
        GetComponent<AudioSource>().Play();

        //
        yield return new WaitForSeconds(waitToLoad);

        //
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }

    /// <summary>
    /// 
    /// </summary>
    public void HandleLoseCondition()
    {
        //
        loseLabel.SetActive(true);

        //
        Time.timeScale = 0;
    }

    /// <summary>
    /// 
    /// </summary>
    public void LevelTimerFinished()
    {
        //
        levelTimerFinished = true;

        //
        StopSpawners();
    }

    /// <summary>
    /// 
    /// </summary>
    private void StopSpawners()
    {
        //
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();

        //
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            //
            spawner.StopSpawning();
        }
    }
}
