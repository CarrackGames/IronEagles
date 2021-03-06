﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject thrusters;
	public GameObject hull;
	public GameObject shield;
	public GameObject shipOuter;
	public GameObject shipInner;
	public GameObject pauseMenu;
	public Vector3 landingTarget;
	private Vector3 mousePosition;
	public static bool viewMode2d;
	public static bool mouseLookControls = true;
	public static bool boosting = false;
	public static bool paused = false;
	public static bool shielded;
	public static bool landingSequence;
	public static float velocity = 0f;
	public float landingSpeed;
	public float health = 1000f;
	public float maxhealth = 1000f;
	public static float healthperc = 100;

	void LandingTarget(Vector3 landingPosition) {

		landingTarget = landingPosition;

	}
	void Landable(bool landable) {
		if (landable == true) {

			landingSequence = true;
			Debug.Log ("Landing");
		}
	

		if (landable == false) {

			landingSequence = false;
		}
	}

	void ShieldChange( bool shielding) {

		shielded = shielding;
	}

	void Start () {

		viewMode2d = true;
		mouseLookControls = false;
		landingSequence = false;

	}

	void Damage(float damage) {

		shield.gameObject.SendMessage ("Damage", damage);

		if (shielded == false) {
			health = health - damage;
		}
	}

	void FixedUpdate () {

		if (landingSequence == true) {

			var lx = transform.position.x - landingTarget.x;
			var ly = transform.position.y - landingTarget.y;
			var x = lx / landingSpeed;
			var y = ly / landingSpeed;
			if (Vector3.Distance (transform.position, landingTarget) <= 5) {

				transform.position = landingTarget;
			}
		}

		healthperc = (health / maxhealth) * 100f;
		hull.gameObject.SendMessage ("Health", healthperc);
	}

	void Update () {

		if (Input.GetKey ("escape")) {

			if (paused == false) {
				paused = true;
				Time.timeScale = 0;
				pauseMenu.SetActive(true);
			}
		}
			
		if (paused == false) {

			var x = Mathf.Abs (Input.GetAxis ("Horizontal"));
			var y = Mathf.Abs (Input.GetAxis ("Vertical"));

			velocity = x + y;

			if (Input.GetKeyDown ("left shift")) {
				boosting = true;
				shipInner.SendMessage("Boosting", true);
				shipOuter.SendMessage("Boosting", true);
			}

			if (Input.GetKeyUp ("left shift")) {
				boosting = false;
				shipInner.SendMessage("Boosting", false);
				shipOuter.SendMessage("Boosting", false);
			}

			thrusters.SendMessage ("Velocity", velocity);
			thrusters.SendMessage ("Boosting", boosting);

			if (mouseLookControls == true) {
				mousePosition = Input.mousePosition;
				mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);

				Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.forward);
				transform.rotation = rot;
				transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);


			}
		}
	}
}
