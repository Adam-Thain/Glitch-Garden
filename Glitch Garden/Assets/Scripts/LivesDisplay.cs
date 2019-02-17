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
    [SerializeField] int baseLives = 5;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] int damage = 1;

    /// <summary>
    /// 
    /// </summary>
    float lives;

    /// <summary>
    /// 
    /// </summary>
    Text livesText;

    /// <summary>
    /// 
    /// </summary>
    private void Start()
    {
        lives = baseLives - PlayerPrefsController.GetDifficulty();

        //
        livesText = GetComponent<Text>();

        //
        UpdateDisplay();

        Debug.Log("difficulty setting currently is " + PlayerPrefsController.GetDifficulty());
    }

    /// <summary>
    /// 
    /// </summary>
    private void UpdateDisplay()
    {
        //
        livesText.text = baseLives.ToString();
    }

    public void TakeLife()
    {
        //
        baseLives -= damage;

        //
        UpdateDisplay();

        //
        if (baseLives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}