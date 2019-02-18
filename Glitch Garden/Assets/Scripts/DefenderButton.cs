using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField] Defender defenderPrefab;



    /// <summary>
    /// 
    /// </summary>
    private void Start()
    {
        //
        LabelButtonWithCost();
    }

    /// <summary>
    /// 
    /// </summary>
    private void LabelButtonWithCost()
    {
        //
        Text costText = GetComponentInChildren<Text>();

        // IF
        // ELSE
        if (!costText)
        {
            //
            Debug.LogError(name + " has no cost text, add some!");
        }
        else
        {
            //
            costText.text = defenderPrefab.GetStarCost().ToString();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    private void OnMouseDown()
    {
        //
        var buttons = FindObjectsOfType<DefenderButton>();

        //
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }

        //
        GetComponent<SpriteRenderer>().color = Color.white;

        //
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
