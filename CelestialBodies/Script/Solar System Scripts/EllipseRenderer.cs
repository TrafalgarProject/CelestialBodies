﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class EllipseRenderer : MonoBehaviour {

	LineRenderer lr;

	[Range(3,255)]
	public int segments;
	public Ellipse ellipse;
    public float yyAxis = 0;
    void Awake(){
		lr = GetComponent<LineRenderer> ();
       // lr.enabled = true;
		CalculateEllips ();
	}

	void CalculateEllips(){
		Vector3[] points = new Vector3[segments + 1];
		for (int i = 0; i < segments; i++) {
			Vector2 position2D = ellipse.Evaluate ((float)i/(float)segments);
			points[i] = new Vector3(position2D.x, yyAxis, position2D.y);
		}
		points [segments] = points [0];
		lr.positionCount = segments + 1;
		lr.SetPositions (points);
	}

	void OnValidate()
	{
		if (Application.isPlaying && lr != null)
			CalculateEllips ();
	}


}
