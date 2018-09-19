using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSNavigationMenu : MonoBehaviour {

   public bool _showOrbitum, _showOrbitumSave;
    GameObject[] lrShow;
   public GameObject btn_ShowTrue;
   public GameObject btn_ShowFalse;

    void Start () {
        lrShow = GameObject.FindGameObjectsWithTag("OrbitumObj");
    }
	
	// Update is called once per frame
	void Update () {
        if (_showOrbitum)
        {
            foreach (GameObject go in lrShow)
            {
                go.GetComponent<LineRenderer>().enabled = true;
            }
        }
        else
        {
            foreach (GameObject go in lrShow)
            {
                go.GetComponent<LineRenderer>().enabled = false;
            }
        }
	}

    public void ShowOrbitumTrue()
    {
        _showOrbitum = true;
        _showOrbitumSave = true;
        btn_ShowTrue.SetActive(false);
        btn_ShowFalse.SetActive(true);
    }

    public void ShowOrbitumFalse()
    {
        _showOrbitum = false;
        _showOrbitumSave = false;
        btn_ShowTrue.SetActive(true);
        btn_ShowFalse.SetActive(false);
    }
}
