using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

    /// <summary>
    /// Camera
    /// </summary>
    public Camera myCamera;

    /// <summary>
    /// Defender Parent
    /// </summary>
    private GameObject parent;

    /// <summary>
    ///  
    /// </summary>
    private StarDisplay starDisplay;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // find DefenderParent
        parent = GameObject.Find("Defenders");

        //
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();

        // If Defenders parent cannot be found crate a new Defenders gameobject for it
        if (!parent)
        {
            parent = new GameObject("Defenders");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    void OnMouseDown()
    {
        Vector2 rawPos = CalculateWorldPointOfMouseClick();
        Vector2 roundedPos = SnapToGrid(rawPos);
        GameObject defender = Button.selectedDefender;

        int defenderCost = defender.GetComponent<Defender>().starCost; 

        //
        //
        if(starDisplay.UseStars(defenderCost) == StarDisplay.Status.SUCCESS)
        {
            SpawnDefender(roundedPos, defender);
        } 
        else
        {
            Debug.Log("Insufficient stars to spawn");
        }
    }

    private void SpawnDefender(Vector2 roundedPos, GameObject defender)
    {
        Quaternion zeroRot = Quaternion.identity;
        GameObject newDef = Instantiate(defender, roundedPos, zeroRot) as GameObject;

        newDef.transform.parent = parent.transform;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="rawWorldPos"></param>
    /// <returns></returns>
    Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(newX,newY);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Vector2 CalculateWorldPointOfMouseClick()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10f;

        Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);
        Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);

        return worldPos;
    }
}
