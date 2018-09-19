using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SSDateTime : MonoBehaviour {

    public GameObject enteredObject;
    int dateYearPlus;
    int dateYearMinus;
    int dateYearPause;
    public Text dateText;

    string dateStr;

    DateTime today = DateTime.Today;
    DateTime datePlus;
    DateTime dateMinus;
    DateTime datePause;

    bool _datePauseStart;

    public bool _orbitProgessPlus;
    public bool _orbitProgessMinus;

    public bool _animateCourtineStop;
    public bool _animateCourtineStart;

    public GameObject Btn_DTMinus;
    public GameObject Btn_DTStart;
    public GameObject Btn_DTPause;
    public GameObject Btn_DTPlus;

    public bool _stopOrbitingProgress;

    public GameObject TriggerCamera;
    public GameObject RAYCam;
    FunctionCamera fun;
    CameraRAY ray;

    public bool _lookDateTime;
    public bool _pauseLookDateTime = false;

    private void Start()
    {
        dateYearPause = -2;
        dateYearMinus = 0;
        dateYearPlus = 0;
        if (_orbitProgessPlus == false && _orbitProgessMinus == false)
        {
            dateStr = today.ToString("dd.MMMM.yyyy");
            datePause = today;
            _datePauseStart = true;
        }
        fun = TriggerCamera.GetComponent<FunctionCamera>();
        ray = RAYCam.GetComponent<CameraRAY>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "TRiggerCamera")
        {
            enteredObject = other.gameObject;

            if (enteredObject.tag != "MoonObj")
            {
                if (enteredObject.tag != "PlanetObjName")
                {
                    if (enteredObject.tag != "ObjName")
                    {
                        if (_orbitProgessPlus)
                        {
                            dateYearPlus += 1;
                            dateYearMinus = 0;
                            dateYearPause = 0;

                            dateStr = datePlus.AddYears(dateYearPlus).ToString("dd.MMMM.yyyy");
                            dateMinus = DateTime.Parse(dateStr);
                            datePause = DateTime.Parse(dateStr);
                            dateText.text = dateStr;

                        }
                        else if (_orbitProgessMinus)
                        {
                            dateYearMinus += 1;
                            dateYearPlus = 0;
                            dateYearPause = 0;
                            dateStr = dateMinus.AddYears(-dateYearMinus).ToString("dd.MMMM.yyyy");

                            datePlus = DateTime.Parse(dateStr);

                            datePause = DateTime.Parse(dateStr);
                            dateText.text = dateStr;
                        }
                        else
                        {
                            dateYearPause = 0;
                            dateYearPlus = 0;
                            dateYearMinus = 0;
                            dateStr = datePause.AddYears(dateYearPause).ToString("dd.MMMM.yyyy");
                            if (_datePauseStart)
                            {
                                dateMinus = DateTime.Parse(dateStr);
                                datePlus = DateTime.Parse(dateStr);
                            }
                            dateText.text = dateStr;
                        }
                    }
                }
            }
        }
    }

    public void Btn_DateTimePlus()
    {
        Btn_DTMinus.GetComponent<Button>().interactable = true;
        Btn_DTPlus.GetComponent<Button>().interactable = false;
        _orbitProgessPlus = true;
        _orbitProgessMinus = false;
        _stopOrbitingProgress = false;
        _animateCourtineStart = false;

        fun._rotateObj = false;
        fun._zoomObj = false;

        _lookDateTime = true;
        _pauseLookDateTime = false;
    }

    public void Btn_DateTimeMinus()
    {
        _orbitProgessPlus = false;
        _orbitProgessMinus = true;
        Btn_DTMinus.GetComponent<Button>().interactable = false;
        Btn_DTPlus.GetComponent<Button>().interactable = true;
        _stopOrbitingProgress = false;
        _animateCourtineStart = false;

        fun._rotateObj = false;
        fun._zoomObj = false;
        _lookDateTime = true;
        _pauseLookDateTime = false;
    }

    public void Btn_DateTimePause()
    {
        Btn_DTPause.SetActive(false);
        Btn_DTStart.SetActive(true);
        Btn_DTMinus.GetComponent<Button>().interactable = false;
        Btn_DTPlus.GetComponent<Button>().interactable = false;
        _orbitProgessPlus = false;
        _orbitProgessMinus = false;
        _animateCourtineStop = true;
        _animateCourtineStart = false;
        _stopOrbitingProgress = false;

        fun._rotateObj = true;
        fun._zoomObj = true;
        _pauseLookDateTime = true;
        _lookDateTime = true;
    }
    public void Btn_DateTimeReset()
    {
        _stopOrbitingProgress = true;
        _animateCourtineStart = false;
        dateYearPlus = 0;
        dateYearMinus = 0;
        dateYearPause = 0;
        _orbitProgessPlus = false;
        _orbitProgessMinus = false;
        _animateCourtineStop = false;
        datePlus = today;
        datePause = today;
        dateMinus = today;
        dateStr = today.ToString("dd.MMMM.yyyy");
        Btn_DTMinus.GetComponent<Button>().interactable = true;
        Btn_DTPlus.GetComponent<Button>().interactable = true;
        Btn_DTStart.SetActive(false);
        Btn_DTPause.SetActive(true);
        dateText.text = today.ToString("dd.MMMM.yyyy");

        fun._rotateObj = true;
        fun._zoomObj = true;
        _pauseLookDateTime = true;
        _lookDateTime = true;
    }
    public void Btn_DateTimeStart()
    {
        Btn_DTStart.SetActive(false);
        Btn_DTPause.SetActive(true);
        Btn_DTMinus.GetComponent<Button>().interactable = true;
        Btn_DTPlus.GetComponent<Button>().interactable = true;
        _orbitProgessPlus = false;
        _orbitProgessMinus = false;
        _animateCourtineStop = false;
        _animateCourtineStart = true;
        _stopOrbitingProgress = false;

        fun._rotateObj = true;
        fun._zoomObj = true;
        _pauseLookDateTime = true;
        _lookDateTime = true;
    }
}
