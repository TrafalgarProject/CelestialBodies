using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SolarSystemCamera : MonoBehaviour {

    public Camera SSCamera;
    float limit = 90;
    bool _rotateSolarSystem;
    private float X, Y;
    Vector3 offset;
    Vector3 ZoomAndRotateObjPositionHit;
    Vector3 mousePos;
    float zoomMax = 700;
    bool _rotateCamera;
    float MyAngle = 0F;
    float sensitivity = 1.5f;

    float input;
    float zoom = 10f;
    float zoomMin = 250;
    bool _zoomObj;

    // Use this for initialization
    void Start () {
        ZoomAndRotateObjPositionHit = new Vector3 (0,0,0);
        limit = Mathf.Abs(limit);
        if (limit > 90) limit = 90;
        offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax));
        _rotateSolarSystem = true;
        _rotateCamera = true;
        _zoomObj = true;
    }
	
	// Update is called once per frame
	void Update () {
        mousePos = Input.mousePosition;
        input = Input.GetAxis("Mouse ScrollWheel");

        if (EventSystem.current.IsPointerOverGameObject()) // если по курсором UI 
        {
            _rotateCamera = false;
        }
        else
        {
            _rotateCamera = true;
        }

        // Вращение камеры вокруг себя
        if (_rotateCamera)
        {
            if (Input.GetMouseButton(0))
            {
                MyAngle = 0;
                MyAngle = sensitivity * ((mousePos.x - (Screen.width / 2)) / Screen.width);
                SSCamera.transform.RotateAround(SSCamera.transform.position, SSCamera.transform.up, MyAngle);
                MyAngle = sensitivity * ((mousePos.y - (Screen.height / 2)) / Screen.height);
                SSCamera.transform.RotateAround(SSCamera.transform.position, SSCamera.transform.right, -MyAngle);

            }
        }
        // Зумирование камеры
        if (input != 0) //если крутится колесико мыши
        {
            if (_zoomObj)
            {
                if (Input.GetAxis("Mouse ScrollWheel") > 0) offset.z += zoom;
                else if (Input.GetAxis("Mouse ScrollWheel") < 0) offset.z -= zoom;
                offset.z = Mathf.Clamp(offset.z, -Mathf.Abs(zoomMax), -Mathf.Abs(zoomMin));
                transform.position = transform.localRotation * offset + ZoomAndRotateObjPositionHit;
            }
        }
    }
}
