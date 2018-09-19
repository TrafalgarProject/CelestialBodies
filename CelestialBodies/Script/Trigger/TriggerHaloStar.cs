using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHaloStar : MonoBehaviour {

    GameObject enteredObject;
    public GameObject haloBig,haloLittle;

    private void OnTriggerEnter(Collider other)
    {
        enteredObject = other.gameObject;

        if (enteredObject.tag == "TRiggerCamera")
        {
            haloLittle.SetActive(true);
            haloBig.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        enteredObject = other.gameObject;

        if (enteredObject.tag == "TRiggerCamera")
        {
            haloBig.SetActive(true);
            haloLittle.SetActive(false);
        }
    }
}
