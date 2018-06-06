using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipMove : MonoBehaviour {
	
	public float turnSpeed = 4f;
	public float booster = 2f;
	public float speed = 1f;
	public float boostTurn = 0.85f;
	public float thrustTurn = 4f;

	void Boosting (bool boosting) {
		if (boosting == true) {
			turnSpeed = boostTurn;
		} else {
			turnSpeed = thrustTurn;
		}
	}

	void FixedUpdate () {

		var b = (Input.GetAxis ("Fire3") * booster + 1);
		var x = (Input.GetAxis ("Horizontal") * speed * b);
		var y = (Input.GetAxis ("Vertical") * speed * b);

		transform.Translate (x, y, 0);

		if (PlayerController.mouseLookControls == false) {

			var r = (Input.GetAxis ("Rotate") * turnSpeed);

			transform.Rotate (0, 0, r);
		}
	}
}
