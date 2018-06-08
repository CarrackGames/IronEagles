using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerlordWeapons : MonoBehaviour {
	
	public float weaponSlots = 24;
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
	public GameObject turretR1;
	public GameObject turretR2;
	public GameObject turretR3;
	public GameObject turretR4;
	public GameObject turretR5;
	public GameObject turretL1;
	public GameObject turretL2;
	public GameObject turretL3;
	public GameObject turretL4;
	public GameObject turretL5;


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
			gun3R1.SendMessage ("Fire");
			gun3R2.SendMessage ("Fire");
			gun3R3.SendMessage ("Fire");
			gun3L1.SendMessage ("Fire");
			gun3L2.SendMessage ("Fire");
			gun3L3.SendMessage ("Fire");
		}

		if (Input.GetKey ("space")) {
			turretR1.SendMessage("Fire");
			turretR2.SendMessage("Fire");
			turretR3.SendMessage("Fire");
			turretR4.SendMessage("Fire");
			turretR5.SendMessage("Fire");
			turretL1.SendMessage("Fire");
			turretL2.SendMessage("Fire");
			turretL3.SendMessage("Fire");
			turretL4.SendMessage("Fire");
			turretL5.SendMessage("Fire");
		}
	}
}
