using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehavior : MonoBehaviour
{

    public void PlayButton()
    {
        SceneManager.LoadScene("2D");
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene("Settings Scene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
