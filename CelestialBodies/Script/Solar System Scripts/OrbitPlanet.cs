using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitPlanet : MonoBehaviour {

    public Transform orbitingObj;
    public Ellipse orbitPath;

    [Range(0f, 1f)]
    public float orbitProgess = 0f;
    public float orbitPeriod = 3f;
    public bool orbitActive = true;

    public bool _orbitProgessPlus;
    public bool _orbitProgessMinus;

    bool _animateCourtineStart;
    public bool _animateCourtineStop;

    float orbitSpeed;


    GameObject ssPlanetObj;
    SSDateTime ssDateTimeScript;
    ContextMenu conmenu;
    GameObject conmenuobj;

    // Use this for initialization
    void Start()
    {

        ssPlanetObj = GameObject.Find("SSTrigerDate");
        ssDateTimeScript = ssPlanetObj.GetComponent<SSDateTime>();
        conmenuobj = GameObject.Find("TriggerCamera");
        conmenu = conmenuobj.GetComponent<ContextMenu>();

        orbitSpeed = 1f / orbitPeriod;

        if (orbitingObj == null)
        {
            orbitActive = false;
            return;
        }
        SetOrbitingObjPosition();
    }

    void SetOrbitingObjPosition()
    {
        Vector2 orbitPos = orbitPath.Evaluate(orbitProgess);
        orbitingObj.localPosition = new Vector3(orbitPos.x, 0, orbitPos.y);
    }


    IEnumerator AnimateOrbit()
    {
        if (orbitPeriod < 0.1f)
        {
            orbitPeriod = 0.1f;
        }

       
        while (orbitActive)
        {
            orbitProgess += Time.deltaTime * orbitSpeed;
            orbitProgess %= 1f;
            SetOrbitingObjPosition();
                yield return null;
        }

    }

    void StopOrbitProgress()
    {
        ssDateTimeScript._stopOrbitingProgress = false;
    }
}
