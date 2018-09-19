using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextObj : MonoBehaviour {

    public TextMesh[] text;
    public Camera cam;
    public bool _uuuuuu;
    SSTextObj sstxt;
    public GameObject trig;

    // Use this for initialization
    void Start () {
        sstxt = trig.GetComponent<SSTextObj>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void Btn3dText()
    {
        sstxt._uuuuuu = false;
        foreach (TextMesh item in text)
        {
            item.fontSize = 40;
            item.transform.localPosition = new Vector3(-1, 0, 0);
            item.transform.localRotation = Quaternion.Euler(new Vector3(0, 180, 0));
            item.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
}
