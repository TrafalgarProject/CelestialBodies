using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GraphisSettings : MonoBehaviour {

    public Dropdown dropdown;
    public Dropdown resolutionDropDawn;
    Resolution[] res;
    public Toggle toggleScreen;
    // Use this for initialization
    void Start () {

        if (PlayerPrefs.HasKey("FullScreen"))
        {
            if (PlayerPrefs.GetInt("FullScreen") == 0)
            {
                Screen.fullScreen = false;
                toggleScreen.isOn = !Screen.fullScreen;
            }
            else {
                Screen.fullScreen = true;
                toggleScreen.isOn = !Screen.fullScreen;
            }
        }
        else
        {
            Screen.fullScreen = true;
            toggleScreen.isOn = !Screen.fullScreen;
        }

        dropdown.ClearOptions();
        dropdown.AddOptions(QualitySettings.names.ToList());

        if (PlayerPrefs.HasKey("Quality"))
        {
            dropdown.value = PlayerPrefs.GetInt("Quality");
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Quality"));
        }
        else {
            dropdown.value = QualitySettings.GetQualityLevel();
        }

        Resolution[] resolution = Screen.resolutions;
        res = resolution.Distinct().ToArray();
        string[] strRes = new string[res.Length];
        for (int i = 0; i < res.Length; i++)
        {
            strRes[i] = res[i].width.ToString() + " x " + res[i].height.ToString();
        }
        resolutionDropDawn.ClearOptions();
        resolutionDropDawn.AddOptions(strRes.ToList());
        if (PlayerPrefs.HasKey("Res"))
        {
            resolutionDropDawn.value = PlayerPrefs.GetInt("Res");
            Screen.SetResolution(res[PlayerPrefs.GetInt("Res")].width, res[PlayerPrefs.GetInt("Res")].height, Screen.fullScreen);
        }
        else
        {
            resolutionDropDawn.value = res.Length - 1;
            Screen.SetResolution(res[res.Length - 1].width, res[res.Length - 1].height, Screen.fullScreen);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetQuality()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("Quality", dropdown.value);
    }
    public void SetRes()
    {
        Screen.SetResolution(res[resolutionDropDawn.value].width, res[resolutionDropDawn.value].height, Screen.fullScreen);
        PlayerPrefs.GetInt("Res", resolutionDropDawn.value);
    }

    public void SetToogleScreen()
    {
        Screen.fullScreen = !toggleScreen.isOn;
        if (Screen.fullScreen == true)
        {
            PlayerPrefs.SetInt("FullScreen", 1);
        }
        else
        {
            PlayerPrefs.SetInt("FullScreen", 0);
        }
    }
}
