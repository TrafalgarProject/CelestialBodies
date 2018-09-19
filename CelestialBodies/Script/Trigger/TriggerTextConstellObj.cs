using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTextConstellObj : MonoBehaviour {

    public GameObject enteredObject;
    public TextMesh text;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        enteredObject = other.gameObject;

        if (enteredObject.tag == "TRiggerCamera")
        {
            text.gameObject.SetActive(true);
            text.fontSize = 20;
            text.transform.localPosition = new Vector3(0.8f, 0, 0);
            text.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}
