using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombatMind : MonoBehaviour {

	public float playerHostility = 6f;
	public float shipHostility = 0f;
	public GameObject target;

	void Sighting (GameObject ship) {

		if (ship.tag == "Player") {
			if (playerHostility >= 5f) {
				target = ship;
			}
		}
	}

	void FixedUpdate () {

		Quaternion rot = Quaternion.LookRotation (transform.position - target.transform.position, Vector3.forward);
		transform.rotation = rot;
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
	}
}
