using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FunctionCamera : MonoBehaviour {

    #region Числовые переменные
    /// <summary>
    /// 
    /// </summary>
    private float X, Y;
    float limit = 80;
    float zoom = 0.25f;
    float zoomMax = 15;
    float zoomMin = 5;
    private float MyAngle = 0F;
    float sensitivity = 1.5f;
    public float input;
    #endregion

    #region Основные вектора
    /// <summary>
    /// offset
    /// ZoomAndRotateObjPositionHit
    /// mousePos
    /// EndPositionCamera
    /// StartPositionCamera
    /// </summary>
    public Vector3 offset;
    public Vector3 ZoomAndRotateObjPositionHit;
    Vector3 mousePos;
    public Vector3 EndPositionCamera;
    public Vector3 StartPositionCamera;
    #endregion

    #region Подключаемые файлы
    Move move;
    TriggerCamera trigerCamera;
    CameraRAY ray;
    SSDateTime dateTime;
    #endregion

    #region Буливские переменные
    /// <summary>
    /// _zoomObj - маштобирование объекта
    /// _rotateObj - вращение объекта
    /// _objcenter - централизирование объекта
    /// _rotateCamera - вращение камеры
    /// </summary>
    public bool _zoomObj;
    public bool _rotateObj;
    public bool _objcenter;
    public bool _rotateCamera = true;
    #endregion

    #region Объекты
    /// <summary>
    /// Main_Camera - Главная камера
    /// TrigerCamera - объект триггера камеры
    /// DateTime - объект даты
    /// rayobj - объект камеры с файлом Райкаста
    /// StartObj - Стартовый объект
    /// Panel - Навигационная панель
    /// LookGO - объект за которым следит триггер камеры
    /// </summary>
    public Camera Main_Camera;
    public GameObject TrigerCamera;
    public GameObject DateTime;
    public GameObject rayobj;
    public GameObject StartObj;
    public GameObject Panel;
    public GameObject LookGO;
    #endregion
// Use this for initialization
    void Start () {
        limit = Mathf.Abs(limit);
        if (limit > 90) limit = 90;
        offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax));
        move = LookGO.GetComponent<Move>();
        trigerCamera = TrigerCamera.GetComponent<TriggerCamera>();
        ray = rayobj.GetComponent<CameraRAY>();
        Main_Camera.transform.LookAt(TrigerCamera.transform);

        ZoomAndRotateObjPositionHit = new Vector3(StartObj.transform.position.x, StartObj.transform.position.y, StartObj.transform.position.z);
        _rotateObj = true;
        _zoomObj = true;
        dateTime = DateTime.GetComponent<SSDateTime>();
    }
	
	// Update is called once per frame
	void Update () {
        mousePos = Input.mousePosition;
        input = Input.GetAxis("Mouse ScrollWheel");
        StartPositionCamera = transform.position;
        if (EventSystem.current.IsPointerOverGameObject()) // если по курсором UI 
        {
            _rotateCamera = false;   
        }
        else
        {
            _rotateCamera = true;
        }

        // Вращение камеры вокруг объекта
        if (Input.GetMouseButton(1))
        {
            if (_rotateObj)
            {
                EndPositionCamera = transform.position;
                X = TrigerCamera.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * 3;
                Y += Input.GetAxis("Mouse Y") * 3;
                Y = Mathf.Clamp(Y, -limit, limit);
                TrigerCamera.transform.localRotation = Quaternion.Euler(-Y, X, 0);
                TrigerCamera.transform.position = TrigerCamera.transform.localRotation * offset + ZoomAndRotateObjPositionHit;
            }
        }
        // Вращение камеры вокруг себя
        if (_rotateCamera)
        {
            if (Input.GetMouseButton(0))
            {
                MyAngle = 0;
                MyAngle = sensitivity * ((mousePos.x - (Screen.width / 2)) / Screen.width);
                Main_Camera.transform.RotateAround(Main_Camera.transform.position, Main_Camera.transform.up, MyAngle);
                MyAngle = sensitivity * ((mousePos.y - (Screen.height / 2)) / Screen.height);
                Main_Camera.transform.RotateAround(Main_Camera.transform.position, Main_Camera.transform.right, -MyAngle);

            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                MyAngle = 0;
                sensitivity = 4f;
                MyAngle = sensitivity * ((mousePos.x - (Screen.width / 2)) / Screen.width);
                Main_Camera.transform.RotateAround(Main_Camera.transform.position, Main_Camera.transform.up, MyAngle);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                MyAngle = 0;
                sensitivity = 4f;
                MyAngle = sensitivity * ((mousePos.x - (Screen.width / 2)) / Screen.width);
                Main_Camera.transform.RotateAround(Main_Camera.transform.position, Main_Camera.transform.up, -MyAngle);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                MyAngle = 0;
                MyAngle = sensitivity * ((mousePos.y - (Screen.height / 2)) / Screen.height);
                Main_Camera.transform.RotateAround(Main_Camera.transform.position, Main_Camera.transform.right, -MyAngle);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                MyAngle = 0;
                MyAngle = sensitivity * ((mousePos.y - (Screen.height / 2)) / Screen.height);
                Main_Camera.transform.RotateAround(Main_Camera.transform.position, Main_Camera.transform.right, MyAngle);
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

        if (move.click)
        {
            TrigerCamera.transform.LookAt(move.target);
            Main_Camera.transform.LookAt(move.target);

            move.click = false;
        }
        else
        {
            TrigerCamera.transform.LookAt(null);
            Main_Camera.transform.LookAt(null);
        }
        if (move.clickHome)
        {
            TrigerCamera.transform.LookAt(StartObj.transform);
            Main_Camera.transform.LookAt(StartObj.transform);

            move.clickHome = false;
        }
        else
        {
            TrigerCamera.transform.LookAt(null);
            Main_Camera.transform.LookAt(null);
        }
    }
}
