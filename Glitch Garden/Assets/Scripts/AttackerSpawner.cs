using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AttackerSpawner : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] float minSpawnDelay = 1f;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] float maxSpanwDelay = 2f;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] Attacker attackerPrefab;

    /// <summary>
    /// 
    /// </summary>
    bool spawn = true;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    IEnumerator Start () {
	
        //
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpanwDelay));
            SpawnAttacker();
        }

	}

    /// <summary>
    /// 
    /// </summary>
    private void SpawnAttacker()
    {
        //
        Attacker newAttacker = Instantiate(attackerPrefab, transform.position, transform.rotation) as Attacker;

        //
        newAttacker.transform.parent = transform;
    }
}
