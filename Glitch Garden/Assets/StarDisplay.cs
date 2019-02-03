using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

    private Text starText;
    private int stars = 0;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {
        starText = GetComponent<Text>();
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
    public void UseStars(int amount)
    {
        stars -= amount;
        UpdateDisplay();
    }

    /// <summary>
    /// 
    /// </summary>
    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }
}
