using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    /// <summary>
    /// Projectile and Parent
    /// </summary>
    public GameObject projectile,gun;

    /// <summary>
    /// Projectile Parent
    /// </summary>
    private GameObject projectileParent;

    /// <summary>
    /// 
    /// </summary>
    private Animator animator;

    /// <summary>
    /// 
    /// </summary>
    private Spawner myLaneSpawner;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        animator = GameObject.FindObjectOfType<Animator>();

        // find projectileparent
        projectileParent = GameObject.Find("Projectiles");

        // If projectile parent cannot be found crate a new projectiles gameobject for it
        if(!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");
        }

        SetMyLaneSpawner();
        print(myLaneSpawner);
    }

    /// <summary>
    /// 
    /// </summary>
    void Update()
    {
        // IF
        // ELSE
        if(IsAttackerAheadInLane())
        {
            animator.SetBool("isAttacking",true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    void SetMyLaneSpawner()
    {
        Spawner[] spawnerArray = GameObject.FindObjectsOfType<Spawner>();

        foreach(Spawner spawner in spawnerArray)
        {
            if (spawner.transform.position.y == transform.position.y)
            {
                myLaneSpawner = spawner;
                return;
            }
        }

        Debug.LogError(name + "Cant find Spawner in lane");
    }
    

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    bool IsAttackerAheadInLane()
    {
        // IF
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }

        // IF
        foreach (Transform attacker in myLaneSpawner.transform)
        {
            if(attacker.transform.position.x > transform.position.x)
            {
                return true;
            }
        }

        //
        return false;
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
