using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public void setFullscreenn(bool isFullscreen)
    {
        Debug.Log("FullScreen"); 
        Screen.fullScreen = isFullscreen; 
    }
}
