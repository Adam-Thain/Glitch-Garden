using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField] int starCost = 100;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public int GetStarCost()
    {
        return starCost;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    public void AddStars(int amount)
    {
        //
        FindObjectOfType<StarDisplay>().AddStars(amount);
    }
}
