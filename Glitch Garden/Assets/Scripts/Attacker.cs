using UnityEngine;
using System.Collections;

/// <summary>
/// This Script requires the Rigidbody2D to work
/// </summary>
[RequireComponent (typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {

    /// <summary>
    /// Current speed of the attacker
    /// </summary>
    private float currentSpeed;

    /// <summary>
    /// Current target of the attacker
    /// </summary>
    private GameObject currentTarget;
         
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {

	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}

    /// <summary>
    /// 
    /// </summary>
    void OnTriggerEnter2D (){
        Debug.Log(name + " trigger enter");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="speed"></param>
    public void SetSpeed(float speed){
        currentSpeed = speed;
    }
    
    /// <summary>
    /// Called from the animator at the time of the actual attack
    /// </summary>
    /// <param name="damage"></param>
    public void StrikeCurrentTarget(float damage){
        Debug.Log(name + "caused " + damage + " damage");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    public void Attack(GameObject obj){
        currentTarget = obj;
    } 
}
