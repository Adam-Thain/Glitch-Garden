using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

    [Range(-1f, 1.5f)]
    public float currentSpeed;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {
        Rigidbody2D myRigidbody = gameObject.AddComponent<Rigidbody2D>();
        myRigidbody.isKinematic = true;
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
    /// 
    /// </summary>
    /// <param name="damage"></param>
    public void StrikeCurrentTarget(float damage){
        Debug.Log(name + "caused " + damage + " damage");
    }
}
