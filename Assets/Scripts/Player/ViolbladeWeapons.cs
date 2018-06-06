using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViolbladeWeapons : MonoBehaviour {
	
	public float weaponSlots = 14;
	public GameObject gun1R1;
	public GameObject gun1R2;
	public GameObject gun1R3;
	public GameObject gun1L1;
	public GameObject gun1L2;
	public GameObject gun1L3;
	public GameObject gun2R;
	public GameObject gun2L;
	public GameObject gun3R1;
	public GameObject gun3R2;
	public GameObject gun3R3;
	public GameObject gun3L1;
	public GameObject gun3L2;
	public GameObject gun3L3;
	public GameObject turret1;
	public GameObject turret2R;
	public GameObject turret2L;


	void Start(){


	}

	void FixedUpdate () {

		if (Input.GetKey ("mouse 0")) {

			gun1R1.SendMessage ("Fire");
			gun1R2.SendMessage ("Fire");
			gun1R3.SendMessage ("Fire");
			gun1L1.SendMessage ("Fire");
			gun1L2.SendMessage ("Fire");
			gun1L3.SendMessage ("Fire");
		}
			
		if (Input.GetKey ("mouse 1")) {
			gun2R.SendMessage ("Fire");
			gun2L.SendMessage ("Fire");
		}

		if (Input.GetKey ("space")) {
			turret1.SendMessage("Fire");
			turret2R.SendMessage("Fire");
			turret2L.SendMessage("Fire");
		}
	}
}
