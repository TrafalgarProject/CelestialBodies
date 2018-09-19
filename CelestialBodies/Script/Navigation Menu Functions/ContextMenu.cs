using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ContextMenu : MonoBehaviour {
    public GameObject MenuContextPanel; // Панель контекстного меню
    public Transform MenuContextTransform; // позиция контекстного меню
    public bool _positionContextMenu;
    float verticalOffset = -100; // отступ от мыши по вертикали
    float horizontalOffset = -100;  // отступ от мыши по горинзонтали

    FunctionCamera FunCam;
    public GameObject TriggerObj;
	CameraRAY CameraRay;
    public Camera MainCamera;

    public bool _g;

	public bool _ObjCenter;
    public bool _ContextMenuActive = false;

    void Start () {
        MenuContextPanel.SetActive(false);
        FunCam = TriggerObj.GetComponent<FunctionCamera>();
        CameraRay = MainCamera.GetComponent<CameraRAY>();
    }
	
	void Update () {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            if (hit.collider != null)
            {
                _positionContextMenu = true;
            }         
        }
        else
        {
            _positionContextMenu = false;
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (_positionContextMenu)
            {
                var position = (Vector2)Input.mousePosition + (Vector2.up * verticalOffset) + (Vector2.left * horizontalOffset);
                MenuContextTransform.position = position;
            }
        }
		if (Input.GetMouseButton(0) || FunCam.input != 0)
            {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                if (_positionContextMenu == false)
                {
                    MenuContextPanel.SetActive(false);
                }
            }
        }
        // Появления контекстного меню при отпускании левой кнопки мыши
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (_positionContextMenu)
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
                {
                    if (hit.collider != null)
                    {
                        if (FunCam.StartPositionCamera == FunCam.EndPositionCamera)
                        {
                            MenuContextPanel.SetActive(true);
                        }
                    }
                }
                else if (!EventSystem.current.IsPointerOverGameObject())
                {
                    MenuContextPanel.SetActive(true);
                }     
            }
        }
        // Запрет перемещея и появления контекстного пока зажата левая кнопка мыши
        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (_positionContextMenu)
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
                {
                    if (hit.collider != null)
                    {
                        FunCam.EndPositionCamera = transform.position;
                        if (FunCam.StartPositionCamera != FunCam.EndPositionCamera)
                        {
                            MenuContextPanel.SetActive(false);
                        }

                    }
                }
                else if (!EventSystem.current.IsPointerOverGameObject())
                {
                    MenuContextPanel.SetActive(false);
                }
            }
        }

		if (MenuContextPanel.activeInHierarchy == true) {
			_ContextMenuActive = true;
            _g = true;
        } 
		else if (MenuContextPanel.activeInHierarchy == false) 
		{
			_ContextMenuActive = false;
            _g = false;
        }

        if (_ObjCenter)
        {
            FunCam.Main_Camera.transform.LookAt(CameraRay.targetCamera);
            _ObjCenter = false;
        }
        else
        {
            FunCam.Main_Camera.transform.LookAt(null);
        }
    }
	public void ObjCenter()
	{
		_ObjCenter = true;
	}
}
