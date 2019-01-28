using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    /// <summary>
    /// Projectile and Parent
    /// </summary>
    public GameObject projectile, projectileParent,gun;

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
