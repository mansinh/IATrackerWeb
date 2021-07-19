using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScreenMainMenu:MonoBehaviour
{
    public void onNew()
    {
        SceneManager.LoadScene("screen_characterSelect");
    }
    public void onLoad()
    {
        SceneManager.LoadScene("screen_load");
    }
    public void onCreate()
    {
        SceneManager.LoadScene("screen_characterCreation");
    }
    public void onImperial()
    {
        SceneManager.LoadScene("screen_imperial");
    }
}
