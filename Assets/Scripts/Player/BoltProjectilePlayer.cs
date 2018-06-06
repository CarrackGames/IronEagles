using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltProjectilePlayer : MonoBehaviour {
	
	public AudioClip sound;
	public float boltspeed = 1;
	public float lifetime = 100;
	public float coolDown = 5;
	public float damage = 10;

	void FixedUpdate () {
	
		transform.Translate (0, boltspeed, 0);
		lifetime = lifetime - 1;
		if (lifetime <= 0) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
			
		if (coll.gameObject.tag == "Ship") {
			coll.gameObject.SendMessage ("Damage", damage);
			Destroy (gameObject);
		}
	}
}
