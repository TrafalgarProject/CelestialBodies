using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllipseRendererMoons : MonoBehaviour
{
    public Transform aroundPoint;//вокруг какого объекта крутиться
    public float circleInSecond;//кругов в секунду

    public float circleInSecondSave;

    public float offsetSin = 1; //если значения не 1, то будет овальное смещение
    public float offsetCos = 1;

    float dist;
    float circleRadians = Mathf.PI * 2;
    public float currentAng;

    GameObject ssPlanetObj;
    SSDateTime ssDateTimeScript;

    public bool _orbitProgessPlus;
    public bool _orbitProgessMinus;
    public bool _animateCourtineStop;
    public bool _animateCourtineStart;
    public bool _animateReset;

   bool _startRotateObj = true;
   public float currentAngSave;
    void Start()
    {
        circleInSecondSave = circleInSecond;
        currentAngSave = currentAng;
        ssPlanetObj = GameObject.Find("SSTrigerDate");
        ssDateTimeScript = ssPlanetObj.GetComponent<SSDateTime>();
        dist = (transform.position - aroundPoint.position).magnitude;
    }

    private void LateUpdate()
    {
        _orbitProgessPlus = ssDateTimeScript._orbitProgessPlus;
        _orbitProgessMinus = ssDateTimeScript._orbitProgessMinus;
        _animateCourtineStop = ssDateTimeScript._animateCourtineStop;
        _animateCourtineStart = ssDateTimeScript._animateCourtineStart;
        _animateReset = ssDateTimeScript._stopOrbitingProgress;

        if (_orbitProgessPlus)
        {
            circleInSecond = 0.2f;
            _orbitProgessPlus = false;
        }
        if (_orbitProgessMinus)
        {
            circleInSecond = -0.2f;
            _orbitProgessMinus = false;
        }
        if (_animateCourtineStop)
        {
            _startRotateObj = false;
            _orbitProgessPlus = false;
            _orbitProgessMinus = false;
        }
        if (_animateCourtineStart)
        {
            _startRotateObj = true;
            _orbitProgessPlus = false;
            _orbitProgessMinus = false;
            circleInSecond = circleInSecondSave;
        }
        if (_animateReset)
        {
            currentAng = currentAngSave;
            circleInSecond = circleInSecondSave;
            _animateCourtineStart = true;
        }
    }

    void Update()
    {
        Vector3 p = aroundPoint.position;
        p.x += Mathf.Sin(currentAng) * dist * offsetSin;
        p.z += Mathf.Cos(currentAng) * dist * offsetCos;
        transform.position = p;

        if (_startRotateObj)
        {
            currentAng += circleRadians * circleInSecond * Time.deltaTime;
        }
        
    }

}
