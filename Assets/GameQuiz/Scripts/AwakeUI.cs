using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeUI : MonoBehaviour
{
    public static void Awake()
    {
        // Set mobile display res.
        Screen.SetResolution(640, 960, false);
    }

    public void Start()
    {
        Screen.SetResolution(640, 960, false);
    }

    //public static int ScreenWidth = Screen.width;
    //public static int ScreenHeight = Screen.height;

    //// Start is called before the first frame update
    //public static void Start()
    //{
    //    // 2560 1920 1280 640 (- 640)
    //    // 1440 1080 720 360 (- 360)

    //    if (ScreenWidth == Screen.width || ScreenHeight == Screen.height)
    //    {
    //        ScreenHeight = Screen.width - (640 * 2);
    //        ScreenWidth = Screen.height - (360 * 2);
    //        Screen.SetResolution(ScreenWidth, ScreenHeight, false);
    //    }
    //}
}
