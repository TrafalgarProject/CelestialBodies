using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAndPlanetNameShowHidden : MonoBehaviour {

    GameObject[] Name;

    FunctionCamera fun;
    public GameObject TriggerCamera;

    public bool _name;
    public GameObject PlanetsAndStarShowBtn, PlanetsAndStarHiddenBtn;

    // Use this for initialization
    void Start () {
        fun = TriggerCamera.GetComponent<FunctionCamera>();
        
        Name = GameObject.FindGameObjectsWithTag("ObjName");
        _name = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (_name)
        {
            foreach (GameObject item3 in Name)
            {
               item3.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject item4 in Name)
            {
               item4.SetActive(false);
            }
        }
    }

    public void Btn_PlanetsAndStarShow()
    {
        _name = true;
        PlanetsAndStarShowBtn.SetActive(false);
        PlanetsAndStarHiddenBtn.SetActive(true);
    }
    public void Btn_PlanetsAndStarHidden()
    {
        _name = false;
        PlanetsAndStarShowBtn.SetActive(true);
        PlanetsAndStarHiddenBtn.SetActive(false);
    }
}
