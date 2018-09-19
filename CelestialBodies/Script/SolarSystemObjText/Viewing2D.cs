using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewing2D : MonoBehaviour {

    DataBase db;
    ShowHiddenFunction fun;
    Move move;

    public GameObject Viewing3DBtn, Viewing2DBtn;
    public GameObject TriggerCamera, SSTriggerCamera, LookTriggerCamera;
    public Camera Camera_SSTriggerCamera, Camera_TriggerCamera;
    public GameObject CenterLookAt;
    public GameObject GOManagger;
    public GameObject Sol;
    GameObject[] lrShow;
    SSNavigationMenu orbitumPlanets;
    // Use this for initialization
    void Start()
    {
        lrShow = GameObject.FindGameObjectsWithTag("OrbitumObj");
        orbitumPlanets = GOManagger.GetComponent<SSNavigationMenu>();
        db = SSTriggerCamera.GetComponent<DataBase>();
        fun = GOManagger.GetComponent<ShowHiddenFunction>();
        move = LookTriggerCamera.GetComponent<Move>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (fun._planets)
        {
            foreach (GameObject go in lrShow)
            {
                go.GetComponent<LineRenderer>().widthMultiplier = 0.8f;
            }
        }

        if (fun._planets == false)
        {
            move.targetSave = Sol.transform;
        }
    }

    public void Btn_Viewing2D()
    {
        Viewing2DBtn.SetActive(false);
        Viewing3DBtn.SetActive(true);



        TriggerCamera.transform.position = new Vector3(0, 500, 0);
        TriggerCamera.transform.Rotate(90, 0, 0);
        TriggerCamera.transform.LookAt(CenterLookAt.transform);
        Camera_TriggerCamera.transform.LookAt(CenterLookAt.transform);
        TriggerCamera.transform.LookAt(null);
        Camera_TriggerCamera.transform.LookAt(null);
        TriggerCamera.SetActive(false);
        SSTriggerCamera.SetActive(true);

        db._navigationTextPanelDB = true;
        db._MoonsObjInfo = false;
        db._PlanetsObjInfo = false;
        db._StarObjInfo = true;

        db.target = Sol.transform;
        db.bodiesID = Sol.name;

        SSTriggerCamera.transform.LookAt(CenterLookAt.transform);
        Camera_SSTriggerCamera.transform.LookAt(CenterLookAt.transform);
        SSTriggerCamera.transform.LookAt(null);
        Camera_SSTriggerCamera.transform.LookAt(null);


    }
}
