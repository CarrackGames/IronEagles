using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronEagleWeapons : MonoBehaviour {

	public float weaponSlots = 4;
	public GameObject gun1R;
	public GameObject gun1L;
	public GameObject gun2R;
	public GameObject gun2L;
	void FixedUpdate () {

		if (Input.GetKey ("mouse 0")) {

			gun1R.SendMessage ("Fire");
			gun1L.SendMessage ("Fire");
		}

		if (Input.GetKey ("mouse 1")) {
			gun2R.SendMessage ("Fire");
			gun2L.SendMessage ("Fire");
		}

		if (Input.GetKey ("space")) {
		}
	}
}
