using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    Defender defender;

    /// <summary>
    /// 
    /// </summary>
    private void OnMouseDown()
    {
        AttemptToPlaceDefenderAt(GetSquareClicked());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="defenderToSelect"></param>
    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="gridPos"></param>
    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        //
        var StarDisplay = FindObjectOfType<StarDisplay>();

        //
        int defenderCost = defender.GetStarCost();

        //
        if (StarDisplay.HaveEnoughStars(defenderCost))
        {
            //
            SpawnDefender(gridPos);

            //
            StarDisplay.SpendStars(defenderCost);
        }
    }

    private Vector2 GetSquareClicked()
    {
        //
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        //
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);

        //
        Vector2 gridPos = SnapToGrid(worldPos);

        //
        return gridPos;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="rawWorldPos"></param>
    /// <returns></returns>
    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        //
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        //
        return new Vector2(newX, newY);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="roundedPos"></param>
    private void SpawnDefender(Vector2 roundedPos)
    {
        Defender newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as Defender;
    }
}
