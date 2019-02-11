using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] float speed = 10f;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] float damage = 50f;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {

        //
        transform.Translate(Vector2.right * speed * Time.deltaTime);
	}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="otherCollider"></param>
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //
        var health = otherCollider.GetComponent<Health>();

        //
        var attacler = otherCollider.GetComponent<Attacker>();

        if (attacler && health)
        {
            // Reduce Health
            health.DealDamage(damage);

            // Destroy Projectile
            Destroy(gameObject);
        }
    }
}
