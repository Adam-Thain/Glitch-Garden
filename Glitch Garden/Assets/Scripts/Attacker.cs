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
    /// Animator of the attacker
    /// </summary>
    private Animator animator;
         
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {
        animator = GetComponent<Animator>();       
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);

        // If there is no target set is attacking to false
        if (!currentTarget)
        {
            animator.SetBool("isAttacking", false);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    void OnTriggerEnter2D (){

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
    /// <param name="damage"> The amound of damage delt </param>
    public void StrikeCurrentTarget(float damage){

        // If there is a target for out attacker
        if(currentTarget)
        {
            // Get the targets health script 
            Health health = currentTarget.GetComponent<Health>();

            // If the target has health
            if(health)
            {
                // Apply damage to the target
                health.DealDamage(damage);
            }
        }       
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    public void Attack(GameObject obj){
        currentTarget = obj;
    } 
}
