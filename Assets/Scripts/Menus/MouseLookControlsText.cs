using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseLookControlsText : MonoBehaviour {

	public GameObject playerShip;
	public Text trueFalse;

	public void OnButton(){

		var ship = playerShip;
		var outer = ship.GetComponent<PlayerController> ().shipOuter;
		var inner = ship.GetComponent<PlayerController> ().shipInner;

		if (PlayerController.mouseLookControls == true) {
			PlayerController.mouseLookControls = false;
			outer.GetComponent<PlayerShipMove> ().enabled = false;
			inner.GetComponent<PlayerShipMove> ().enabled = true;
		} else {
			if (PlayerController.mouseLookControls == false) {
				PlayerController.mouseLookControls = true;
				outer.GetComponent<PlayerShipMove> ().enabled = true;
				inner.GetComponent<PlayerShipMove> ().enabled = false;
			}
		}
	}

	void Update () {
		if (PlayerController.mouseLookControls == true) {
			trueFalse.text = ("true");
		}

		if (PlayerController.mouseLookControls == false) {
			trueFalse.text = ("false");
		}
	}
}
