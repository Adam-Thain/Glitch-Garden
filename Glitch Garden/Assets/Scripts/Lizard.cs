using UnityEngine;
using System.Collections;

/// <summary>
/// This Script requires the attacker script to work
/// </summary>
[RequireComponent(typeof(Attacker))]
public class Lizard : MonoBehaviour
{

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
    void Start()
    {

        // Get fox animator 
        anim = GetComponent<Animator>();

        // Get Attacker script
        attacker = GetComponent<Attacker>();

    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {

    }

    /// <summary>
    /// When the fox collides with another game object
    /// </summary>
    /// <param name="collider"></param>
    void OnTriggerEnter2D(Collider2D collider)
    {

        GameObject obj = collider.gameObject;

        // Leave method if we are not colliding with a defender
        if (!obj.GetComponent<Defender>())
        {
            return;
        }

        anim.SetBool("isAttacking", true);
        attacker.Attack(obj);
        
        Debug.Log("Lizard collided with " + collider);
    }
}