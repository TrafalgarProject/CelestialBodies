using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SSTextObj : MonoBehaviour {

    public TextMesh[] text3;
    public TextMesh[] text;
    public Camera cam;
    public bool _uuuuuu;
   public GameObject[] objNameSS;
    void Start()
    {
        objNameSS = GameObject.FindGameObjectsWithTag("ObjName");  
    }

        public void Btn2dText()
    {
        _uuuuuu = true;

        for (int i = 0; i < objNameSS.Length; i++)
        {
            objNameSS[i].transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        for (int i = 0; i < text3.Length; i++)
        {
            text3[i].transform.localRotation = Quaternion.Euler(new Vector3(90, 0, 0));
        }
        foreach (TextMesh item in text3)
        {
            item.fontSize = 50;
            item.transform.localPosition = new Vector3(1, 0, 0);
            item.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        foreach (TextMesh item in text)
        {
            item.fontSize = 120;
            item.transform.localPosition = new Vector3(1, 0, 0);
            item.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
            item.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
