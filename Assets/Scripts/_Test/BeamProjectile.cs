using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamProjectile : MonoBehaviour {

	public float boltspeed = 1;
	public float lifetime = 100;
	public float coolDown = 5;

	void Update () {
	
		transform.Translate (0, boltspeed, 0);
		lifetime = lifetime - 1;
		if (lifetime <= 0) {
			Destroy (gameObject);
		}
		
	}
}
