using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombatMind : MonoBehaviour {

	public float slowdown = 10f;
	public float distance;
	public float maxSpeed = 0.75f;
	public float combatRange = 5f;
	public float playerHostility = 6f;
	public float shipHostility = 0f;
	public float velocity;
	public bool boosting;
	public Vector2 movements;
	public GameObject target;
	public GameObject weapons;
	public GameObject thrusters;

	private void Start()
	{
		boosting = false;
	}

	void Sighting (GameObject ship) {

		if (ship.tag == "Player") {
			if (playerHostility >= 5f) {
				target = ship;
			}
		}
		if (ship.tag == "Ship") {
			if (shipHostility >= 5f) {
				target = ship;
			}
		}
	}

	void FixedUpdate ()
	{

		distance = Vector2.Distance(target.transform.position, transform.position);
		if (distance >= combatRange) {
			var speed = distance / slowdown;
			speed = Mathf.Clamp (speed, 0f, maxSpeed);
			transform.Translate (0, speed, 0);
		} else { 
			Debug.Log ("Firing");
			weapons.gameObject.SendMessage ("FirePrimary");
		}
		transform.rotation = Quaternion.LookRotation(Vector3.forward, target.transform.position - transform.position);

		movements = transform.position;
		velocity = Vector2.Distance(movements, transform.position);
		thrusters.SendMessage("Velocity", velocity);
		if (velocity >= 0.25)
		{
			thrusters.SendMessage("Boosting", true);
		}
		else
		{
			thrusters.SendMessage("Boosting", false);
		}
	}
}
