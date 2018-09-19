using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewing3D : MonoBehaviour {

    DataBase db;

    public GameObject Viewing3DBtn, Viewing2DBtn;
    public GameObject TriggerCamera, SSTriggerCamera, LookTargetCamera;
    public Camera Camera_TriggerCamera;
    public GameObject Sol;
    public GameObject GOManagger;
    Transform SaveTarget;

    Move move;
    FunctionCamera funCam;

    GameObject[] lrShow;
    SSNavigationMenu orbitumPlanets;
    ShowHiddenFunction fun;

    // Use this for initialization
    void Start () {
        move = LookTargetCamera.GetComponent<Move>();
        funCam = TriggerCamera.GetComponent<FunctionCamera>();

        lrShow = GameObject.FindGameObjectsWithTag("OrbitumObj");
        orbitumPlanets = GOManagger.GetComponent<SSNavigationMenu>();

        db = TriggerCamera.GetComponent<DataBase>();
        fun = GOManagger.GetComponent<ShowHiddenFunction>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (fun._planets)
        {
            foreach (GameObject go in lrShow)
            {
                go.GetComponent<LineRenderer>().widthMultiplier = 3f;
            }
        }
        else
        {
            orbitumPlanets._showOrbitum = false;
        }
    }

    public void Btn_Viewing3D() {

        Viewing2DBtn.SetActive(true);
        Viewing3DBtn.SetActive(false);

        SSTriggerCamera.SetActive(false);
        TriggerCamera.SetActive(true);

        funCam.offset = new Vector3(funCam.offset.x, funCam.offset.y, -15);

        if (fun._planets==false)
        {
            orbitumPlanets._showOrbitum = false;
        }

        if (move.targetSave == null)
        {
            TriggerCamera.transform.position = new Vector3(Sol.transform.position.x, Sol.transform.position.y, Sol.transform.position.z - 15f);
            TriggerCamera.transform.LookAt(Sol.transform);
            Camera_TriggerCamera.transform.LookAt(Sol.transform);

            db._navigationTextPanelDB = true;
            db._MoonsObjInfo = false;
            db._PlanetsObjInfo = false;
            db._StarObjInfo = true;

            db.target = Sol.transform;
            db.bodiesID = Sol.name;
        }
        else
        {
            if (fun._planets == false)
            {
                TriggerCamera.transform.position = new Vector3(Sol.transform.position.x, Sol.transform.position.y, Sol.transform.position.z - 15f);
                TriggerCamera.transform.LookAt(Sol.transform);
                Camera_TriggerCamera.transform.LookAt(Sol.transform);

                db._navigationTextPanelDB = true;
                db._MoonsObjInfo = false;
                db._PlanetsObjInfo = false;
                db._StarObjInfo = true;

                db.target = Sol.transform;
                db.bodiesID = Sol.name;
            }
            else
            {
                TriggerCamera.transform.position = new Vector3(move.targetSave.transform.position.x, move.targetSave.transform.position.y, move.targetSave.transform.position.z - 15f);
                TriggerCamera.transform.LookAt(move.targetSave.transform);
                Camera_TriggerCamera.transform.LookAt(move.targetSave.transform);

                db._navigationTextPanelDB = true;
                db._MoonsObjInfo = false;
                db._PlanetsObjInfo = true;
                db._StarObjInfo = false;

                db.target = move.targetSave.transform;
                db.bodiesID = move.targetSave.name;
            }
        }

        TriggerCamera.transform.Rotate(0, 0, 0);

        TriggerCamera.transform.LookAt(null);
        Camera_TriggerCamera.transform.LookAt(null);
    }
}
