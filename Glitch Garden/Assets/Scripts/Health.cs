using UnityEngine;
using System.Collections;
using System;

public class Health : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] float health = 100f;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] GameObject deathVFX;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="damage"></param>
    public void DealDamage(float damage)
    {
        //
        health -= damage;

        //
        if(health <= 0)
        {
            //
            TriggerDeathVFX();

            //
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    private void TriggerDeathVFX()
    {
        //
        if(!deathVFX) { return; }

        //
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation) as GameObject;
        Destroy(deathVFXObject, 1f);
    }
}
