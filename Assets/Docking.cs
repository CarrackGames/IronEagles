using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Docking : MonoBehaviour {
	public Vector2 location;

	void Start () {

		location = (gameObject.transform.position);
	}

	void OnTriggerEnter2D (Collider2D ship) {

		if (ship.gameObject.tag == "Player") {
			ship.gameObject.SendMessage ("Landable", true);
			ship.gameObject.SendMessage ("LandingTarget", location);
		}
	}

	void OnTriggerLeave2D (Collider2D ship) {

		if (ship.gameObject.tag == "Player") {
			ship.gameObject.SendMessage ("Landable", false);
		}
	}
}
