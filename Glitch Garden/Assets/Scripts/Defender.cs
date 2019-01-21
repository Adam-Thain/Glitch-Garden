using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {
	
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
	
	}

    /// <summary>
    /// 
    /// </summary>
    void OnTriggerEnter2D()
    {
        Debug.Log(name + " trigger enter");
    }
}
