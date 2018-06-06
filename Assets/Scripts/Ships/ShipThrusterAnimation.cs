using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipThrusterAnimation : MonoBehaviour {

	void Destroyed () {
		
		GetComponent<Animator> ().SetBool ("Destroyed", true);
	}

	void Velocity (float veloc) {

		GetComponent<Animator> ().SetFloat ("Speed", veloc);
	
	}

	void Boosting (bool boosti) {
		
		GetComponent<Animator> ().SetBool ("Boost", boosti);

	}
}
