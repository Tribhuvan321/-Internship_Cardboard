using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Management;

public class XRManager : MonoBehaviour
{
    // Call this method to initialize and start XR
    public void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
