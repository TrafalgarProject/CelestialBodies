using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHoverName : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text text;
    TriggerCamera trigcam;
    GameObject trigcamobj,sstrigcam;

    private void Start()
    {
        text.gameObject.SetActive(false);
        trigcamobj = GameObject.Find("TriggerCamera");
        sstrigcam = GameObject.Find("SSTargitCamera");
        trigcam = trigcamobj.GetComponent<TriggerCamera>();
        if (trigcam._buttonName == false)
        {
            text.gameObject.SetActive(false);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.gameObject.SetActive(false);
    }
}
