using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    public GameObject [] attackerPreFabArray;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
	    
        foreach(GameObject thisAttacker in attackerPreFabArray)
        {
            if(isTimeToSpawn(thisAttacker))
            {
                Spawn(thisAttacker);
            }
        }
	}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="myGameObject"></param>
    void Spawn(GameObject myGameObject)
    {
        GameObject myAttacker = Instantiate(myGameObject) as GameObject;
        myAttacker.transform.parent = transform;
        myAttacker.transform.position = transform.position;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="attackerGameObject"></param>
    /// <returns></returns>
    bool isTimeToSpawn(GameObject attackerGameObject)
    {
        //
        Attacker attacker = attackerGameObject.GetComponent<Attacker>();

        //
        float meanSpawnDelay = attacker.seenEverySeconds;

        //
        float spawnPerSecond = 1 / meanSpawnDelay;

        //
        if(Time.deltaTime > meanSpawnDelay)
        {
            Debug.LogWarning("Spawn rate capped by framerate");
        }

        //
        float threshold = spawnPerSecond * Time.deltaTime / 5;

        // IF
        // ELSE
        if(Random.value < threshold)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
