using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    public GameObject defenderPrefab;
    public static GameObject selectedDefender;

    private Button[] buttonArray;
    
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {
        buttonArray = GameObject.FindObjectsOfType<Button>();
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
	
	}

    /// <summary>
    /// When the mouse is clicked
    /// </summary>
    void OnMouseDown()
    {
        foreach(Button thisButton in buttonArray)
        {
            thisButton.GetComponent<SpriteRenderer>().color = Color.black;
        }

        GetComponent<SpriteRenderer>().color = Color.white;
        selectedDefender = defenderPrefab;
        print(selectedDefender);
    }
}
