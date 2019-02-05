using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

    private LevelManager levelManager;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start ()
    {
        //
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

    /// <summary>
    /// 
    /// </summary>
    void OnTriggerEnter2D()
    {
        //
        levelManager.LoadLevel("07 Lose Screen");
    }
}
