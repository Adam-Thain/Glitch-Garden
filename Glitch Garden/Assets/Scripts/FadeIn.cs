using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {
    
    #region Private Members

    /// <summary>
    /// 
    /// </summary>
    private Image fadeInPanal;

    /// <summary>
    /// 
    /// </summary>
    private Color currentColor = Color.black;

    #endregion

    #region Public Members

    /// <summary>
    /// 
    /// </summary>
    public float fadeInTime;

    #endregion

    #region Constructor

    /// <summary>
    /// Use this for initialization
    /// </summary>
    public void Start()
    {
        fadeInPanal = GetComponent<Image>();
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    public void Update()
    {
        // If
        // Else
        if(Time.timeSinceLevelLoad < fadeInTime)
        {
            float alphaChange = Time.deltaTime / fadeInTime;

            currentColor.a -= alphaChange;

            fadeInPanal.color = currentColor;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    #endregion
}
