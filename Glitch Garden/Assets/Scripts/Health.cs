using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float health = 100f;

    /// <summary>
    /// Deal damage to the attached object
    /// </summary>
    /// <param name="damage"> The amount of damage taken </param>
    public void DealDamage(float damage) {

        // Minus damage from health
        health -= damage;

        // If zero or less health is reached
        if (health <= 0)
        {
            // Destroy the game object
            Destroy();
        }
    }

    /// <summary>
    /// Destroy object
    /// </summary>
    public void Destroy()
    {
        // Destroy the game object
        Destroy(gameObject);
    }
}
