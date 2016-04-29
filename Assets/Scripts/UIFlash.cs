using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


/// <summary>
/// Flashes the ui text set
/// </summary>
public class UIFlash : MonoBehaviour {

    //the text component to blink
    public Image toBlink;
    //blink speed
    public float blinkSpeed = 0.5f;

    // Use this for initialization
    void Start()
    {
        //repeat call to BlinkText every 0.5s
        InvokeRepeating("BlinkText", blinkSpeed, blinkSpeed);
    }

    /// <summary>
    /// Enables or disables the text
    /// </summary>
    void BlinkText()
    {
        //check if text is enabled
        if (toBlink.enabled)
        {
            toBlink.enabled = false;
        }
        else
        {
            toBlink.enabled = true;
        }
    }
}
