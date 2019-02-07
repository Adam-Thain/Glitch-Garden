using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

    private Text starText;

    private int stars = 100;

    public enum Status {SUCCESS,FAILURE};

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {
        starText = GetComponent<Text>();
        UpdateDisplay();
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
    public Status UseStars(int amount)
    {
        if(stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
            return Status.SUCCESS;
        }
        return Status.FAILURE;
    }

    /// <summary>
    /// 
    /// </summary>
    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }
}
