using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	
	private AudioSource gs;
	public float cooldown;
	public float volume;
	public float projectileCooldown;
	public GameObject projectile;

	void Start() {
		gs = GetComponent<AudioSource> ();
	}

	void FixedUpdate () {

		volume = 0.5f * Audio.volume;

		if (cooldown >= 0) {
			cooldown = cooldown - 1;
		}
	}

	void Fire () {

		projectileCooldown = projectile.GetComponent<BoltProjectile> ().coolDown;
		var sound = projectile.GetComponent<BoltProjectile> ().sound;


		if (cooldown <= 0) {
			Instantiate (projectile, transform.position, transform.rotation);
			cooldown = projectileCooldown;
			gs.PlayOneShot (sound, volume);
		}
	}
}
