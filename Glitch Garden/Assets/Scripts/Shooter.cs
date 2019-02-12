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
    AttackerSpawner myLaneSpawner;

    /// <summary>
    /// 
    /// </summary>
    Animator animator;

    /// <summary>
    /// 
    /// </summary>
    private void Start()
    {
        //
        SetLaneSpawner();

        //
        animator = GetComponent<Animator>();
    }

    /// <summary>
    /// 
    /// </summary>
    private void Update()
    {
        // IF
        // ELSE
        if (IsAttackerInLane())
        {
            Debug.Log("shoot pew pew");
            animator.SetBool("isAttacking", true);
        }
        else
        {
            Debug.Log("sit and wait");
            animator.SetBool("isAttacking", false);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    private void SetLaneSpawner()
    {
        //
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawners)
        {
            //
            bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);

            //
            if (IsCloseEnough)
            {
                //
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        // IF
        // ELSE
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void Fire()
    {
        //
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
    }
}
