using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreenAndExit : MonoBehaviour {

    public GameObject ExitBtn;
    public GameObject panel;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        if (Screen.fullScreen == true)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }
    public void Btn_Exit()
    {
        Application.Quit();
    }

    public void Btn_Screen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
}
