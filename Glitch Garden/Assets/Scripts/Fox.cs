using UnityEngine;
using System.Collections;

/// <summary>
/// This Script requires the attacker script to work
/// </summary>
[RequireComponent (typeof (Attacker))]
public class Fox : MonoBehaviour {

    /// <summary>
    /// Fox animator
    /// </summary>
    private Animator anim;

    /// <summary>
    /// Attacker Script
    /// </summary>
    private Attacker attacker;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {

        // Get fox animator 
        anim = GetComponent<Animator>();

        // Get Attacker script
        attacker  = GetComponent<Attacker>();

    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
	
	}

    /// <summary>
    /// When the fox collides with another game object
    /// </summary>
    /// <param name="collider"></param>
    void OnTriggerEnter2D(Collider2D collider) {

        GameObject obj = collider.gameObject;

        // Leave method if we are not colliding with a defender
        if(!obj.GetComponent<Defender>()) {
            return;
        }

        // IF the object is a stone jump over it
        // Else attack the object
        if (obj.GetComponent<Stone>()) {
            anim.SetTrigger("jumpTrigger");
        }
        else {
            anim.SetBool("isAttacking", true);
            attacker.Attack(obj);
        }

        Debug.Log("Fox collided with " + collider);
    }
}