using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject targetCamera;
    public Transform target;
    public bool g1;
    // Use this for initialization
    void Start () {
		
	}
	RaycastHit hit;
	// Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 10000000))
            {
                if (hit.collider != null)
                {

                    if (g1)
                    {
                        
                    }

                    //targetCamera = hit.transform.Find("Img").gameObject;
                }
            }
            g1 = true;

        }
    }
}
