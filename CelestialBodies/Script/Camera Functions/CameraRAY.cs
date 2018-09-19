using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRAY : MonoBehaviour {

    /// <summary>
    /// cameras - Подключение главной камеры
    /// targetCamera - Выбранный объект после нажание на кнопки мыши
    /// trigcam - Объект где подключен файл с основным функционалом камеры 
    /// </summary>
    public Camera cameras;
    public Transform targetCamera;
    public GameObject trigcam;
    FunctionCamera fun;

    private void Start()
    {
        fun = trigcam.GetComponent<FunctionCamera>();
    }
    private void LateUpdate()
    { 
        RaycastHit hit;
        if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 10000000))
            {
                if (hit.collider != null)
                {
                    targetCamera = hit.transform;
                }
            }
        }
    }
}
