using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombatMind : MonoBehaviour {

	public float distx;
	public float disty;
	public float distance;
	public float slowdown = 10f;
	public float maxSpeed = 0.75f;
	public float combatRange = 2f;
	public float playerHostility = 6f;
	public float shipHostility = 0f;
	public GameObject target;
	public GameObject weapons;

	void Sighting (GameObject ship) {

		if (ship.tag == "Player") {
			if (playerHostility >= 5f) {
				target = ship;
			}
		}
	}

	void FixedUpdate () {

		distx = Mathf.Abs (transform.position.x);
		disty = Mathf.Abs (transform.position.y);
		distance = distx + disty;
		if (distance >= combatRange) {
			Debug.Log ("Moving In");
			var speed = distance / slowdown;
			speed = Mathf.Clamp (speed, 0f, maxSpeed);
			transform.Translate (0, speed, 0);
		} else { 
			Debug.Log ("Firing");
			weapons.gameObject.SendMessage ("FirePrimary");
		}
		transform.rotation = Quaternion.LookRotation(Vector3.forward, target.transform.position - transform.position);
	}
}
