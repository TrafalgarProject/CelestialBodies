using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerCamera : MonoBehaviour {

    public GameObject enteredObject;
    public GameObject managerObject;
    public GameObject navigationRight;

    FunctionCamera FunCam;
    SphereCollider sphereCollider;

    RightMenu RigMenu;
    ShowHiddenFunction SHFun;
    SSNavigationMenu ssNav;
    StarAndPlanetNameShowHidden starPlanetName;
    RightMenu deg;

    public bool _buttonName = false;

    public GameObject TrigCamObj,Deg;
    public bool _constellStarNameTrigger, b1;

    GameObject[] namebtn;

    public TextMesh[] textObjNameSS, textObjNameSSPlanets;
    public GameObject Trigger_Camera, SSTriggerCamera;
    public Camera cam;
    bool _look;
    SSTextObj sstext;
    GameObject[] objNameSS;

    public GameObject Eatch;
    //Vector3 scal;

    // Use this for initialization
    void Start () {
        FunCam = TrigCamObj.GetComponent<FunctionCamera>();
        RigMenu = TrigCamObj.GetComponent<RightMenu>();
        SHFun = managerObject.GetComponent<ShowHiddenFunction>();
        ssNav = managerObject.GetComponent<SSNavigationMenu>();
        starPlanetName = managerObject.GetComponent<StarAndPlanetNameShowHidden>();

        namebtn = GameObject.FindGameObjectsWithTag("NameButton");
        objNameSS = GameObject.FindGameObjectsWithTag("ObjName");

        sstext = Trigger_Camera.GetComponent<SSTextObj>();
        _look = true;

        foreach (TextMesh item in textObjNameSS)
        {
            item.fontSize = 40;
            item.transform.localPosition = new Vector3(-1, 0, 0);
            item.transform.localRotation = Quaternion.Euler(new Vector3(0, -180f, 0));
            item.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        deg = TrigCamObj.GetComponent<RightMenu>();
    }

    private void Update()
    {
        if (_look)
        {
            foreach (GameObject item in objNameSS)
            {
                item.transform.LookAt(Trigger_Camera.transform);
            }
        }
        if (sstext._uuuuuu)
        {
            _look = false;
        }
        else
        {
            _look = true;
        }

        if (b1)
        {
            foreach (TextMesh item in textObjNameSSPlanets)
            {
                item.fontSize = 40;
                item.transform.localPosition = new Vector3(-1, 0, 0);
                item.transform.localRotation = Quaternion.Euler(new Vector3(0, -180f, 0));
                item.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
            b1 = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "TriggerDateTime")
        {
            if (other.gameObject.tag == "StarObjSS")
            {
                int idObj = Convert.ToInt32(other.gameObject.name)-1;
                    textObjNameSS[idObj].fontSize = 20;
                    textObjNameSS[idObj].transform.localPosition = new Vector3(-1f, 0, 0);
                    textObjNameSS[idObj].transform.localRotation = Quaternion.Euler(new Vector3(0, -180f, 0));
                    textObjNameSS[idObj].transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                
            }
            if (other.gameObject.tag == "PlanetsObj")
            {
                int idObj = Convert.ToInt32(other.gameObject.name);
                textObjNameSS[idObj].fontSize = 20;
                textObjNameSS[idObj].transform.localPosition = new Vector3(-1f, 0, 0);
                textObjNameSS[idObj].transform.localRotation = Quaternion.Euler(new Vector3(0, -180f, 0));
                textObjNameSS[idObj].transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            }
        }

        if (other.gameObject.tag != "TriggerDateTime")
        {
            if (other.gameObject.tag != "ObjName")
            {
                enteredObject = other.gameObject;


                sphereCollider = enteredObject.GetComponent<SphereCollider>();
                if (enteredObject.tag == "SS")
                {
                    navigationRight.SetActive(true);


                    if (deg._degShow)
                    {
                        Deg.SetActive(true);
                    }
                    else
                    {
                        Deg.SetActive(false);
                    }

                    if (ssNav.btn_ShowFalse.GetComponent<Button>().interactable == false)
                    {
                        ssNav._showOrbitum = false;
                    }
                    if (SHFun.ConstellLineHiddenBtn.activeSelf == true)
                    {
                        SHFun._constellLine = true;
                    }
                    else
                    {
                        SHFun._constellLine = false;
                    }
                    if (SHFun.ConstellNameHiddenBtn.activeSelf == true)
                    {
                        SHFun._constellName = true;
                    }
                    else
                    {
                        SHFun._constellName = false;
                    }
                    if (SHFun.ConstellStarNameHiddenBtn.activeSelf == true)
                    {
                        SHFun._constellStarName = true;
                    }
                    else
                    {
                        SHFun._constellStarName = false;
                    }
                    if (starPlanetName.PlanetsAndStarHiddenBtn.activeSelf == true)
                    {
                        starPlanetName._name = true;
                    }
                    else
                    {
                        starPlanetName._name = false;
                    }
                    if (SHFun.PlanetsShowBtn.activeSelf == true)
                    {
                        SHFun._planets = false;
                    }
                    else
                    {
                        SHFun._planets = true;
                    }
                    foreach (GameObject item in namebtn)
                    {
                        item.gameObject.SetActive(false);
                    }
                }
                if (enteredObject.tag == "PlanetsObj")
                {
                    sphereCollider.radius = 0.5f;
                }
            }
        }
        else
        {
            enteredObject = Eatch;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "TriggerDateTime")
        {
            if (other.gameObject.tag == "StarObjSS")
            {
                int idObj = Convert.ToInt32(other.gameObject.name) - 1;
                textObjNameSS[idObj].fontSize = 40;
                textObjNameSS[idObj].transform.localPosition = new Vector3(-1, 0, 0);
                textObjNameSS[idObj].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

            }
            if (other.gameObject.tag == "PlanetsObj")
            {
                int idObj = Convert.ToInt32(other.gameObject.name);
                textObjNameSS[idObj].fontSize = 40;
                textObjNameSS[idObj].transform.localPosition = new Vector3(-1, 0, 0);
                textObjNameSS[idObj].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
        }

        if (other.gameObject.tag != "TriggerDateTime")
        {
            if (other.gameObject.tag != "ObjName")
            {
                enteredObject = other.gameObject;
                FunCam._rotateObj = false;
                FunCam._zoomObj = false;
                

                if (enteredObject.tag == "PlanetsObj")
                {
                    sphereCollider = enteredObject.GetComponent<SphereCollider>();
                    sphereCollider.radius = 2f;
                }
                if (enteredObject.tag == "SS")
                {
                    navigationRight.SetActive(false);
                    SHFun._constellLine = false;
                    SHFun._constellStarName = _constellStarNameTrigger;
                    ssNav._showOrbitum = false;
                    Deg.SetActive(false);
                }
            }
            
        }
        else
        {
            enteredObject = Eatch;
        }
    }
}
