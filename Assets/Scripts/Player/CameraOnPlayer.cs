﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnPlayer : MonoBehaviour {

	public GameObject player;
	public Camera mainCam;
	public float scrollspeed = 1f;
	public float minZoom;
	public float maxZoom;
	public float zoom;

	void Update () {

		transform.position = player.transform.position;
		transform.Translate (0, 0, -10);
		
	}

	void FixedUpdate () {

		var speed = scrollspeed * mainCam.orthographicSize * 0.5f;
		zoom = (Input.GetAxis ("Mouse ScrollWheel") * speed) + mainCam.orthographicSize;

		zoom = Mathf.Clamp (zoom, minZoom, maxZoom);

		mainCam.orthographicSize = zoom;
	}
}
