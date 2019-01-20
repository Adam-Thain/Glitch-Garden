using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {
    
    #region Public Members

    /// <summary>
    /// 
    /// </summary>
    public const string MASTER_VOLUME_KEY = "master_volume";

    /// <summary>
    /// 
    /// </summary>
    public const string DIFFICULTY_KEY = "difficulty";

    /// <summary>
    /// 
    /// </summary>
    public const string LEVEL_KEY = "level_volume";

    #endregion

    #region Public Methods

    /// <summary>
    /// 
    /// </summary>
    /// <param name="volume"></param>
    public static void SetMasterVolume(float volume)
    {
        // If
        // Else
        if (volume >= 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master Volume Out Of Range");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="level"></param>
    public static void UnlockLevel(int level)
    {
        // If
        if (level <= SceneManager.sceneCountInBuildSettings - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); // use 1 for true
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="level"></param>
    /// <returns></returns>
    public static bool IsLevelUnlocked(int level)
    {
        //
        int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());

        //
        bool isLevelUnlocked = (level == 1);

        // If
        // Else
        if (level <= SceneManager.sceneCountInBuildSettings - 1)
        {
            return isLevelUnlocked;
        }
        else
        {
            Debug.LogError("Trying To Query Level Not In Build Order");
            return false;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static void SetDifficulty(float difficulty)
    {
        // If
        // Else
        if (difficulty >= 1f && difficulty <= 3f)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Difficulty Out Of Range");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static float GetDifficulty()
    {
        //
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

    #endregion
}
