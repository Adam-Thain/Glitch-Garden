using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField] int stars = 500;

    /// <summary>
    /// 
    /// </summary>
    Text starText;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        //
        starText = GetComponent<Text>();

        //
        UpdateDisplay();
    }

    /// <summary>
    /// 
    /// </summary>
    private void UpdateDisplay()
    {
        //
        starText.text = stars.ToString();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    /// <returns></returns>
    public bool HaveEnoughStars(int amount)
    {
        //
        return stars >= amount;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    public void SpendStars(int amount)
    {
        if(stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
    }
}
