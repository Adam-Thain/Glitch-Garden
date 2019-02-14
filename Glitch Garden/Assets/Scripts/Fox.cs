using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="otherCollider"></param>
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //
        GameObject otherObject = otherCollider.gameObject;

        // IF
        // ELS
        if (otherObject.GetComponent<Gravestone>())
        {
            //
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }
        else if (otherObject.GetComponent<Defender>())
        {
            //
            GetComponent<Attacker>().Attack(otherObject);
        }
    }
}
