using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [Tooltip("Our Level timer in SECONDS")]

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] float levelTime = 10;

    /// <summary>
    /// 
    /// </summary>
    bool triggeredLevelFinished = false;

    /// <summary>
    /// 
    /// </summary>
    private void Update()
    {
        // IF
        if (triggeredLevelFinished) { return; }

        //
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        //
        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);

        // IF
        if (timerFinished)
        {
            //
            FindObjectOfType<LevelController>().LevelTimerFinished();

            //
            triggeredLevelFinished = true;
        }
    }
}
