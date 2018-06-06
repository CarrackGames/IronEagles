using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMainSprite : MonoBehaviour {

	public float healthPerc = 100f;

	void Destroyed () {

		GetComponent<Animator> ().SetBool ("Destroyed", true);
	}

	void Health(float healthNew) {

		healthPerc = healthNew;
			
	}

	void Update () {

		GetComponent<Animator> ().SetFloat ("Health", healthPerc);

	}
}
