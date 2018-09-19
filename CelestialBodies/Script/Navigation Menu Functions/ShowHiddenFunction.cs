using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHiddenFunction : MonoBehaviour {

    SSNavigationMenu orbitum;
    Move move;
    TriggerCamera triggerCamera;
    DataBase db;
    public GameObject ManagerGO,LookTargetCamera,TriggerCamera,Sol;

	GameObject[] PlanetsMas;
	GameObject[] MoonsMas;
	GameObject[] ConstellName;
	GameObject[] ConstellLine;
    GameObject[] ConstellStarName;
    GameObject[] ConstellPoinerStar;
    public GameObject SettingsPanel,Btn_SettingsTXT, HelpPanel, Btn_HelpTXT,InfoPanel, Btn_TXTInfo;

    public bool _planets;
    public bool _constellName,_constellLine, _constellStarName,_constellPointer;
	public GameObject PlanetsShowBtn, PlanetsHiddenBtn;
	public GameObject ConstellNameShowBtn, ConstellNameHiddenBtn;
	public GameObject ConstellLineShowBtn,ConstellLineHiddenBtn;
    public GameObject ConstellStarNameShowBtn, ConstellStarNameHiddenBtn;
	public GameObject SettingsShowBtn,SettingsHiddenBtn;
    public GameObject HelpShowBtn, HelpHiddenBtn;
    public GameObject Help_Y_Panel, Help_F_Panel;
    public GameObject Help_Y_Btn, Help_F_Btn;
    public Text Txt_Y_Help,Txt_F_Help;
    public GameObject ConstellPoinerStarShowBtn, ConstellPoinerStarHiddenBtn;
    public GameObject InfoShowBtn, InfoHiddenBtn;

    // Use this for initialization
    void Start () {
		PlanetsMas = GameObject.FindGameObjectsWithTag("PlanetsObj");
        ConstellLine = GameObject.FindGameObjectsWithTag("ConstellationLine");
        ConstellName = GameObject.FindGameObjectsWithTag("ConstellName");
        ConstellStarName = GameObject.FindGameObjectsWithTag("ConstellNameStar");
        ConstellPoinerStar = GameObject.FindGameObjectsWithTag("ConstellStarPointer");
        Help_Y_Btn.GetComponent<Button>().interactable = false;
        _planets = true;
        orbitum = ManagerGO.GetComponent<SSNavigationMenu>();
        move = LookTargetCamera.GetComponent<Move>();
        triggerCamera = TriggerCamera.GetComponent<TriggerCamera>();
        db = TriggerCamera.GetComponent<DataBase>();
	}

    // Update is called once per frame
    void Update () {
		if (_planets)
		{
			foreach (GameObject item in PlanetsMas)
			{
				item.SetActive(true);
			}
		}
		else
		{
			foreach (GameObject item2 in PlanetsMas)
			{
				item2.SetActive(false);
			}
        }
        if (_constellName)
		{
			foreach (GameObject item7 in ConstellName)
			{
				item7.SetActive(true);
			}
		}
		else
		{
			foreach (GameObject item8 in ConstellName)
			{
				item8.SetActive(false);
			}
		}
		if (_constellLine)
		{
			foreach  (GameObject item9 in ConstellLine)
			{
				item9.SetActive(true);
			}
		}
		else
		{
			foreach (GameObject item10 in ConstellLine)
			{
				item10.SetActive(false);
			}
		}
        if (_constellStarName)
        {
            foreach (GameObject item in ConstellStarName)
            {
                item.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject item in ConstellStarName)
            {
                item.SetActive(false);
            }
        }
        if (_constellPointer)
        {
            foreach (GameObject item in ConstellPoinerStar)
            {
                item.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject item in ConstellPoinerStar)
            {
                item.SetActive(false);
            }
        }
	}
	public void Btn_PlanetsShow()
	{
		_planets = true;
		PlanetsShowBtn.SetActive(false);
		PlanetsHiddenBtn.SetActive(true);
        if (orbitum._showOrbitumSave)
        {
            orbitum._showOrbitum = true;
            orbitum.btn_ShowFalse.SetActive(true);
            orbitum.btn_ShowTrue.SetActive(false);
            orbitum.btn_ShowFalse.GetComponent<Button>().interactable = true;
            orbitum.btn_ShowTrue.GetComponent<Button>().interactable = true;
        }
        else
        {
            orbitum._showOrbitum = false;
            orbitum.btn_ShowTrue.SetActive(true);
            orbitum.btn_ShowFalse.SetActive(false);
            orbitum.btn_ShowTrue.GetComponent<Button>().interactable = true;
            orbitum.btn_ShowFalse.GetComponent<Button>().interactable = true;
        }
        triggerCamera.b1 = true;

        db._navigationTextPanelDB = true;
        db._MoonsObjInfo = false;
        db._PlanetsObjInfo = false;
        db._StarObjInfo = true;

        db.target = Sol.transform;
        db.bodiesID = Sol.name;
    }
	public void Btn_PlanetsHidden()
	{
		_planets = false;
		PlanetsShowBtn.SetActive(true);
		PlanetsHiddenBtn.SetActive(false);
        if (orbitum._showOrbitumSave)
        {
            orbitum._showOrbitum = false;
            orbitum.btn_ShowFalse.SetActive(true);
            orbitum.btn_ShowFalse.GetComponent<Button>().interactable = false;
        }
        else
        {
            orbitum._showOrbitum = false;
            orbitum.btn_ShowTrue.SetActive(true);
            orbitum.btn_ShowTrue.GetComponent<Button>().interactable = false;
        }
        move.b5 = true;

        db._navigationTextPanelDB = true;
        db._MoonsObjInfo = false;
        db._PlanetsObjInfo = false;
        db._StarObjInfo = true;

        db.target = Sol.transform;
        db.bodiesID = Sol.name;
    }

	public void Btn_ConstellNameShow()
	{
		_constellName = true;
		ConstellNameShowBtn.SetActive(false);
		ConstellNameHiddenBtn.SetActive(true);
	}
	public void Btn_ConstellNameHidden()
	{
		_constellName = false;
		ConstellNameHiddenBtn.SetActive(false);
		ConstellNameShowBtn.SetActive(true);
	}

	public void Btn_ConstellLineShow()
	{
		_constellLine = true;
		ConstellLineShowBtn.SetActive(false);
		ConstellLineHiddenBtn.SetActive(true);
	}
	public void Btn_ConstellLineHidden()
	{
		_constellLine = false;
		ConstellLineShowBtn.SetActive(true);
		ConstellLineHiddenBtn.SetActive(false);
	}

    public void Btn_ConstellStarNameShow()
    {
        _constellStarName = true;
        ConstellStarNameShowBtn.SetActive(false);
        ConstellStarNameHiddenBtn.SetActive(true);
    }
    public void Btn_ConstellStarNameHidden()
    {
        _constellStarName = false;
        ConstellStarNameShowBtn.SetActive(true);
        ConstellStarNameHiddenBtn.SetActive(false);
    }

	public void Btn_SettingsShow()
	{
		SettingsPanel.SetActive (true);
		SettingsShowBtn.SetActive (false);
		SettingsHiddenBtn.SetActive (true);
	}
	public void Btn_SettingsHidden()
	{
		SettingsPanel.SetActive (false);
		SettingsShowBtn.SetActive (true);
		SettingsHiddenBtn.SetActive (false);
        Btn_SettingsTXT.SetActive(false);
	}

    public void Btn_HelpShow() {
        HelpPanel.SetActive(true);
        HelpShowBtn.SetActive(false);
        HelpHiddenBtn.SetActive(true);
    }
    public void Btn_HelpHidden()
    {
        HelpPanel.SetActive(false);
        HelpShowBtn.SetActive(true);
        HelpHiddenBtn.SetActive(false);
        Btn_HelpTXT.SetActive(false);
    }

    public void Btn_YHelp()
    {
        Help_Y_Panel.SetActive(true);
        Help_F_Panel.SetActive(false);
        Help_Y_Btn.GetComponent<Button>().interactable = false;
        Help_F_Btn.GetComponent<Button>().interactable = true;
        Txt_Y_Help.color = new Color(255, 255, 255);
        Txt_F_Help.color = new Color(0, 0, 255);
    }
    public void Btn_FHelp()
    {
        Help_Y_Panel.SetActive(false);
        Help_F_Panel.SetActive(true);
        Help_Y_Btn.GetComponent<Button>().interactable = true;
        Help_F_Btn.GetComponent<Button>().interactable = false;
        Txt_Y_Help.color = new Color(0, 0, 255);
        Txt_F_Help.color = new Color(255, 255, 255);
    }

    public void Btn_ConstellPointerShow()
    {
        _constellPointer = true;
        ConstellPoinerStarShowBtn.SetActive(false);
        ConstellPoinerStarHiddenBtn.SetActive(true);
    }
    public void Btn_ConstellPointerHidden()
    {
        _constellPointer = false;
        ConstellPoinerStarShowBtn.SetActive(true);
        ConstellPoinerStarHiddenBtn.SetActive(false);
    }

    public void Btn_InfoShow()
    {
        InfoPanel.SetActive(true);
        InfoShowBtn.SetActive(false);
        InfoHiddenBtn.SetActive(true);
    }
    public void Btn_InfoHidden()
    {
        InfoPanel.SetActive(false);
        Btn_TXTInfo.SetActive(false);
        InfoShowBtn.SetActive(true);
        InfoHiddenBtn.SetActive(false);
    }
}
