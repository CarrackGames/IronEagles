using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour {

	public GameObject mind;
	
	void OnTriggerEnter2D (Collider2D sighting) {

		if (sighting.gameObject.tag == "Player" || sighting.gameObject.tag == "Ship") {
			mind.SendMessage ("Sighting", sighting.gameObject);
		}
	}
}
