using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class full : MonoBehaviour
{
    public Toggle toggle;

    void Start()
    {
        if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }

    }

    public void ActiveFULLS(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
    }
}