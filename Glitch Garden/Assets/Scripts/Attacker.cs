using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    [Range(0f,5f)]
    [SerializeField] float currentSpeed = 1f;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {

        //
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
	}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="speed"></param>
    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }
}
