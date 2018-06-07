using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewModeText : MonoBehaviour {
	public Camera mainCam;
	public Text viewMode;

	public void OnButton () {
		if (PlayerController.viewMode2d == true) {
			PlayerController.viewMode2d = false;
			viewMode.text = "3D";
			mainCam.orthographic = false;
		} else {
			PlayerController.viewMode2d = true;
			viewMode.text = "2D";
			mainCam.orthographic = true;
		}
	}
}
