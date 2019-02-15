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
    private void Update()
    {
        //
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        //
        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);

        //
        if (timerFinished)
        {
            Debug.Log("Level Timer Expired");
        }
    }
}
