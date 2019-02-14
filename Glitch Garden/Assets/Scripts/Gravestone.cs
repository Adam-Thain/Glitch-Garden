using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="otherCollider"></param>
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //
        Attacker attacker = otherCollider.GetComponent<Attacker>();

        //
        if (attacker)
        {

        }
    }
}
