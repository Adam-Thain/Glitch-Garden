using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    #region public floats

    /// <summary>
    /// Time between next level load
    /// </summary>
    public float autoLoadNextLevelAfter;

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// </summary>
    public void Start()
    {
        // If the first scene is zero (start)
        // Else load the next level automatically 
        if(autoLoadNextLevelAfter == 0)
            Debug.Log("level Auto load Disabled");
        else
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Load level or scenes
    /// </summary>
    /// <param name="name"> name of level </param>
    public void LoadLevel(string name)
    {
        // Load the level
        SceneManager.LoadScene(name);
    }

    /// <summary>
    /// Request to quit the current game
    /// </summary>
	public void QuitRequest()
    {
        // Quit the game
        Application.Quit();
    }

    /// <summary>
    /// Load the next level
    /// </summary>
    public void LoadNextLevel()
    {
        // Load the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    #endregion
}
