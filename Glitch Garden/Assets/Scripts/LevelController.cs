using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
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
            Debug.Log("End Level Now!");
        }
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
