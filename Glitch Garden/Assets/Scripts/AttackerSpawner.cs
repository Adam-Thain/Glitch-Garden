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
    [SerializeField] Attacker[] attackerPrefabArray;

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
    public void StopSpawning()
    {
        spawn = false;
    }

    /// <summary>
    /// 
    /// </summary>
    private void SpawnAttacker()
    {
        //
        var AttackerIndex = Random.Range(0, attackerPrefabArray.Length);

        //
        Spawn(attackerPrefabArray[AttackerIndex]);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="myAttacker"></param>
    private void Spawn(Attacker myAttacker)
    {
        //
        Attacker newAttacker = Instantiate(myAttacker, transform.position, transform.rotation) as Attacker;

        //
        newAttacker.transform.parent = transform;
    }
}
