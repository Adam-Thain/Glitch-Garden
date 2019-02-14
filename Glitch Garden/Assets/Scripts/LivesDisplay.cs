using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField] int lives = 5;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] int damage = 1;

    /// <summary>
    /// 
    /// </summary>
    Text livesText;

    /// <summary>
    /// 
    /// </summary>
    private void Start()
    {
        //
        livesText = GetComponent<Text>();

        //
        UpdateDisplay();
    }

    /// <summary>
    /// 
    /// </summary>
    private void UpdateDisplay()
    {
        //
        livesText.text = lives.ToString();
    }

    public void TakeLife()
    {
        //
        lives -= damage;

        //
        UpdateDisplay();

        //
        if (lives <= 0)
        {
            //
            FindObjectOfType<LevelLoader>().LoadYouLose();
        }
    }
}