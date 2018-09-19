using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    float smoothTime = 0.2F; // Скорость перещещения камеры

    #region
    /// <summary>
    /// _corutineMove - старт перемещения
    /// _corutineMoveHome - старт перемещения к солнцу при нажатии на H
    /// _moveCameraFun - вкл\выкл функций камеры когда объект переместился или нет
    /// _nullPlanet - перемещение к солнцу если отключить планеты
    /// click - запуск перещения
    /// clickHome - запуск перещения к солнцу
    /// </summary>
    public bool _corutineMove, b5;
    public bool _corutineMoveHome = false;
    public bool click, clickHome;
    public bool _moveCameraFun, _nullPlanet = false;
    #endregion

    #region
    /// <summary>
    /// HomeStarVector - вектор солнца
    /// MovePositionHit - позиция выбранного объекта
    /// cameraHasMoved - вектор объекта к которому переместился
    /// velocity - нулевой вектор
    /// </summary>
    Vector3 HomeStarVector;
    public Vector3 MovePositionHit;
    Vector3 cameraHasMoved;
    private Vector3 velocity = Vector3.zero;
    #endregion

    #region Объекты
    /// <summary>
    /// target - объект к которому нужно переместиться
    /// targetSave - сохранить target объект
    /// Main_Camera - главная камера
    /// TriggerCamera - триггер камеры
    /// ManagerGO - менеджер файлов
    /// </summary>
    public Transform target, targetSave;
    public Camera Main_Camera;
    public Transform HomeStarObj;
    public GameObject TriggerCamera, ManagerGO;
    #endregion

    #region Подключаемые файлы
    FunctionCamera funCamera;
    TriggerCamera trigCamera;
    StarAndPlanetNameShowHidden SPName;
    DataBase db;
    #endregion

    // Use this for initialization
    void Start () {
        db = TriggerCamera.GetComponent<DataBase>();
        funCamera = TriggerCamera.GetComponent<FunctionCamera>();
        SPName = ManagerGO.GetComponent<StarAndPlanetNameShowHidden>();
        HomeStarVector = new Vector3(HomeStarObj.transform.position.x, HomeStarObj.transform.position.y, HomeStarObj.transform.position.z - 15f);
	}
	
	// Update is called once per frame
	void Update () {

        cameraHasMoved = transform.position;

        RaycastHit hit;
        if (Input.GetMouseButtonUp(1))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                if (hit.collider != null)
                {
                    target = hit.transform;
                    MovePositionHit = new Vector3(hit.transform.position.x, hit.transform.position.y, hit.transform.position.z - 15f);
                }
            }
        }

        if (_corutineMove)
        {
            StartCoroutine("IMove");
        }
        else
        {
            StopCoroutine("IMove");
        }

        if (_nullPlanet)
        {
            if (SPName.PlanetsAndStarHiddenBtn.activeSelf == true)
            {
                if (_corutineMove == true)
                {
                    _moveCameraFun = false;
                }
                else
                {
                    _moveCameraFun = true;
                }
            }
            else
            {
                if (_corutineMove == true)
                {
                    _moveCameraFun = false;
                }
                else
                {
                    _moveCameraFun = true;
                }
            }
            _nullPlanet = false;
        }

        if (_moveCameraFun)
        {
            if (transform.position == cameraHasMoved)
            {
                funCamera._zoomObj = true;
                funCamera._rotateObj = true;
                funCamera._rotateCamera = true;
                funCamera.ZoomAndRotateObjPositionHit = new Vector3(MovePositionHit.x, MovePositionHit.y, MovePositionHit.z + 15f);
                funCamera.offset = new Vector3(funCamera.offset.x, funCamera.offset.y, -15);

            }
            else
            {
                funCamera._zoomObj = false;
                funCamera._rotateObj = false;
                funCamera._rotateCamera = false;
            }
            _moveCameraFun = false;
        }
        
        if (_corutineMoveHome)
        {
            StartCoroutine("IMoveHome");
        }
        else
        {
            StopCoroutine("IMoveHome");
        }

        if (Input.GetKey(KeyCode.H))
        {
            _corutineMoveHome = true;
            db._navigationTextPanelDB = true;
            db._MoonsObjInfo = false;
            db._PlanetsObjInfo = false;
            db._StarObjInfo = true;
            db.target = HomeStarObj;
            db.bodiesID = HomeStarObj.name;
        }

        if (b5)
        {
            _corutineMoveHome = true;
            db._MoonsObjInfo = false;
            db._PlanetsObjInfo = false;
            db._StarObjInfo = true;
            funCamera._zoomObj = false;
            funCamera._rotateObj = false;
            db.target = HomeStarObj;
            db.bodiesID = HomeStarObj.name;
        }
    }
    public void btn_move()
    {
        _corutineMove = true;
    }

    IEnumerator IMove()
    {
        transform.position = Vector3.SmoothDamp(transform.position, MovePositionHit, ref velocity, smoothTime);
        Main_Camera.transform.LookAt(target);
        targetSave = target;
        if (transform.position == cameraHasMoved)
        {
            _corutineMove = false;
            _nullPlanet = true;
            click = true;
        }
        yield return null;
    }

    IEnumerator IMoveHome()
    {
        transform.position = Vector3.SmoothDamp(transform.position, HomeStarVector, ref velocity, smoothTime);
        Main_Camera.transform.LookAt(HomeStarObj);
        targetSave = target;
        if (transform.position == cameraHasMoved)
        {
            funCamera._zoomObj = true;
            funCamera._rotateObj = true;
            funCamera.ZoomAndRotateObjPositionHit = HomeStarObj.transform.position;
            _corutineMoveHome = false;
            b5 = false;
            clickHome = true;
        }
        yield return null;
    }
}
