using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] GameObject projectile, gun;

    /// <summary>
    /// 
    /// </summary>
    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
    }
}
