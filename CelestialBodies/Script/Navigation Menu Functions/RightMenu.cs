using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMenu : MonoBehaviour {

	public GameObject DegreeGridObj;
	public GameObject Btn_DGTrue;
	public GameObject Btn_DGFalse;

    public bool _degShow;

	public void Btn_DegreeGridTrue()
	{
		DegreeGridObj.SetActive (true);
		Btn_DGTrue.SetActive (false);
		Btn_DGFalse.SetActive (true);
        _degShow = true;
	}

	public void Btn_DegreeGridFalse()
	{
		DegreeGridObj.SetActive (false);
		Btn_DGTrue.SetActive (true);
		Btn_DGFalse.SetActive (false);

        _degShow = false;
	}
}
