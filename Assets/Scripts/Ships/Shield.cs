using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

	public float shieldMaxStrength = 1000f;
	public float shieldStrength = 1000f;
	public float shieldRecharge = 5f;
	public float shieldSinceHit = 0f;
	public bool shielding = true;
	public bool isHit = false;
	public GameObject ship;

	void Start () {
		shielding = true;
	}

	void Damage (float hit) {
		if (shielding == true) {
			if (shieldStrength >= 0) {
				shieldStrength = shieldStrength - hit;
				shieldSinceHit = 50f;
				GetComponent<Animator> ().SetTrigger ("Hit");
			}
		}
	}

	void FixedUpdate () {

		if (shieldStrength <= 0) {
			shielding = false;
			ship.SendMessage ("ShieldChange", false);
		}

		if (shieldStrength == shieldMaxStrength) {
			shielding = true;
			ship.SendMessage ("ShieldChange", true);
		}

		if (shieldSinceHit >= 0.1) {
			shieldSinceHit = shieldSinceHit - 1;
		}

		if (shieldSinceHit <= 0) {
			if (shieldStrength <= shieldMaxStrength) {
				shieldStrength = shieldStrength + shieldRecharge;
			}
		}
	}

	void Update () {

		GetComponent<Animator> ().SetBool ("Shielding", shielding);

	}
}
