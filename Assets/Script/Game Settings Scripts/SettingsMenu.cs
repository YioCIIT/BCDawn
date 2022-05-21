using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public TMP_Dropdown resolutionsDropdown;

    Resolution[] resolutions;
    
    private void Start() {
       resolutions = Screen.resolutions;

       resolutionsDropdown.ClearOptions();

       List<string> options = new List<string>();

        int currentResolutionIndex = 0;
       foreach(Resolution r in resolutions)
       {
           string option = r.width + " x " + r.height;
           options.Add(option);

           if(r.Equals(Screen.currentResolution))
           {
               currentResolutionIndex = Array.IndexOf(resolutions, r);
           }
       }

       resolutionsDropdown.AddOptions(options);
       resolutionsDropdown.value = currentResolutionIndex;
       resolutionsDropdown.RefreshShownValue();
    }

    public void SetResolution (int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Game Volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
