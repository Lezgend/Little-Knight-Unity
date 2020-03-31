using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public Color loadToColor = Color.black;

    public void PlayGame()
    {
        Initiate.Fade("Game", loadToColor, 2.0f);
        AwakeUI.Awake();
        //AwakeUI.Start();

        //SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void MainMenu()
    {
        Initiate.Fade("Menu", loadToColor, 2.0f);
        AwakeUI.Awake();
        //AwakeUI.Start();
    }
}