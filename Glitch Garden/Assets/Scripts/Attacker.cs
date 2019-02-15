using UnityEngine;
using System.Collections;
using System;

public class Attacker : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    [Range(0f,5f)]
    float currentSpeed = 1f;

    /// <summary>
    /// 
    /// </summary>
    GameObject currentTarget;

    /// <summary>
    /// 
    /// </summary>
    private void Awake()
    {
        //
        FindObjectOfType<LevelController>().AttackerSpawned();
    }

    /// <summary>
    /// 
    /// </summary>
    private void OnDestroy()
    {
        //
        FindObjectOfType<LevelController>().AttackerKilled();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {

        //
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);

        //
        UpdateAnimationState();
	}

    /// <summary>
    /// 
    /// </summary>
    private void UpdateAnimationState()
    {
        //
        if (!currentTarget)
        {
            //
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="speed"></param>
    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    public void Attack(GameObject target)
    {
        //
        GetComponent<Animator>().SetBool("isAttacking", true);

        //
        currentTarget = target;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="damage"></param>
    public void StrikeCurrentTarget(float damage)
    {
        //
        if (!currentTarget) { return; }

        //
        Health health = currentTarget.GetComponent<Health>();

        //
        if (health)
        {
            //
            health.DealDamage(damage);
        }
    }
}
