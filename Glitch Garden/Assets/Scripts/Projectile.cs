using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    public float speed, damage;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {
	
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {

        // Move projectile by its current speed once per frame
        transform.Translate(Vector3.right * speed * Time.deltaTime);
	}

    /// <summary>
    /// When the projectile collides with an enemy
    /// </summary>
    /// <param name="collider"></param>
    void OnTriggerEnter2D (Collider2D collider) {

        // Get the attacker script
        Attacker attacker = collider.gameObject.GetComponent<Attacker>();

        // Get the health script
        Health health = collider.gameObject.GetComponent<Health>();

        // If the collider is an attacker
        if(attacker && health)
        {
            // Deal damage to the target
            health.DealDamage(damage);

            // Destroy the projectile
            Destroy(gameObject);
        }
    }
}