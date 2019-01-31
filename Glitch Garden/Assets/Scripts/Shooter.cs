using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    /// <summary>
    /// Projectile and Parent
    /// </summary>
    public GameObject projectile, projectileParent,gun;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // find projectileparent
        projectileParent = GameObject.Find("Projectiles");

        // If projectile parent cannot be found crate a new projectiles gameobject for it
        if(!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");

        }
    }

    /// <summary>
    /// Fire a projectile
    /// </summary>
    private void Fire()
    {
        GameObject newProjectile = Instantiate(projectile) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }
}
