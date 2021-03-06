﻿using UnityEngine;
using System.Collections;

public class PixelPerfectCamera : MonoBehaviour {

	public static float pixelsToUnits = 1f;
	public static float scale = 1;
	public Vector2 nativeResolution = new Vector2(240,160);
	//resolution of Gameboy Advanced

	void Awake () {
		//Create a reference to the camera
		var camera = GetComponent<Camera> ();

		if (camera.orthographic) {
			scale = Screen.height/nativeResolution.y;
			pixelsToUnits *= scale;
			camera.orthographicSize	= (Screen.height / 2.0f / pixelsToUnits); 
		}
	}

}
