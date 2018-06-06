using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

	public GameObject thrusters;
	public GameObject hull;
	public GameObject shield;
	public GameObject shipOuter;
	public GameObject shipInner;
	private Vector3 mousePosition;
	public static bool mouseLookControls = true;
	public static bool boosting = false;
	public static bool paused = false;
	public static bool shielded;
	public static float velocity = 0f;
	public float health = 1000f;
	public float maxhealth = 1000f;
	public static float healthperc = 100;
	public bool doomed;
	public float doomedCountdown = 85f;


	void ShieldChange( bool shielding) {

		shielded = shielding;
	}

	void Start () {

		doomed = false;
		mouseLookControls = false;

	}

	void Damage(float damage) {

		shield.gameObject.SendMessage ("Damage", damage);

		if (shielded == false) {
			health = health - damage;
		}
	}

	void FixedUpdate () {
		
		healthperc = (health / maxhealth) * 100f;
		hull.gameObject.SendMessage ("Health", healthperc);
		if (doomed == false) {
			if (health <= 0) {
				doomed = true;
			}
		}

		GetComponent<Animator> ().SetBool ("Doomed", doomed);

		if (doomed == true) {
			doomedCountdown = doomedCountdown - 1;
		}

		if (doomedCountdown <= 30) {
			hull.SendMessage ("Destroyed");
			thrusters.SendMessage ("Destroyed");
		}

		if (doomedCountdown <= 0) {
			Destroy (shipOuter);
		}
	}

	void Update () {
			
		if (paused == false) {

			if (doomed == false) {
			
				if (Input.GetKeyDown ("left shift")) {
					boosting = true;
				}

				if (Input.GetKeyUp ("left shift")) {
					boosting = false;
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
}
