using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    private StarDisplay starDisplay;

    /// <summary>
    /// 
    /// </summary>
    void Start() {
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
    }

    /// <summary>
    /// Only used as a tag for now
    /// </summary>
    /// <param name="amount"></param>
    public void AddStars (int amount)
    {
        starDisplay.AddStars(amount);
    }
}
