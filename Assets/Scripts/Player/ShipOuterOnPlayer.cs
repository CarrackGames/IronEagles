﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipOuterOnPlayer : MonoBehaviour {

	public GameObject player;

	void Update () {

		transform.position = player.transform.position;
		transform.rotation = player.transform.rotation;
		
	}
}
