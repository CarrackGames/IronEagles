﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronEagleWeapons : MonoBehaviour {

	public float volume = 0.5f;
	public float weaponSlots = 4;
	public GameObject gun1R;
	public GameObject gun1L;
	public GameObject gun2R;
	public GameObject gun2L;
	public GameObject projectileType1;
	public GameObject projectileType2;
	public GameObject projectileType3;
	public GameObject projectileType4;
	public float cooldown1;
	public float cooldown2;
	public float cooldown3;
	public float cooldown4;
	public AudioSource g1;
	public AudioSource g2;
	public AudioSource g3;
	public AudioSource g4;

	void Start(){

		g1 = gun1R.GetComponent<AudioSource> ();
		g2 = gun1L.GetComponent<AudioSource> ();
		g3 = gun2R.GetComponent<AudioSource> ();
		g4 = gun2L.GetComponent<AudioSource> ();
	}

	void FixedUpdate () {

		var vol = volume * Audio.volume;
		var p1 = projectileType1;
		var p2 = projectileType2;
		var p3 = projectileType3;
		var p4 = projectileType4;

		var pc1 = p1.GetComponent<BoltProjectilePlayer> ().coolDown;
		var pc2 = p2.GetComponent<BoltProjectilePlayer> ().coolDown;
		var pc3 = p3.GetComponent<BoltProjectilePlayer> ().coolDown;
		var pc4 = p4.GetComponent<BoltProjectilePlayer> ().coolDown;

		var sound1 = p1.GetComponent<BoltProjectilePlayer> ().sound;
		var sound2 = p2.GetComponent<BoltProjectilePlayer> ().sound;
		var sound3 = p3.GetComponent<BoltProjectilePlayer> ().sound;
		var sound4 = p4.GetComponent<BoltProjectilePlayer> ().sound;

		var pr = gun1R.transform.position;
		var pl = gun1L.transform.position;
		var sr = gun2R.transform.position;
		var sl = gun2L.transform.position;
		var m = transform.rotation;

		if (cooldown1 <= 0) {
			if (Input.GetKey ("mouse 0")) {
				Instantiate (projectileType1, pr, m);
				cooldown1 = pc1;
				g1.PlayOneShot (sound1, vol);
			}
		} else {
			cooldown1 = cooldown1 - 1;
		}

		if (cooldown2 <= 0) {
			if (Input.GetKey ("mouse 0")) {
				Instantiate (projectileType2, pl, m);
				cooldown2 = pc2;
				g2.PlayOneShot (sound2, vol);
			}
		} else {
			cooldown2 = cooldown2 - 1;
		}

		if (cooldown3 <= 1) {
			if (Input.GetKey ("mouse 1")) {
				Instantiate (projectileType3, sr, m);
				cooldown3 = pc3;
				g3.PlayOneShot (sound3, vol);
			}
		} else {
			cooldown3 = cooldown3 - 1;
		}

		if (cooldown4 <= 1) {
			if (Input.GetKey ("mouse 1")) {
				Instantiate (projectileType4, sl, m);
				cooldown4 = pc4;
				g4.PlayOneShot (sound4, vol);
			}
		} else {
			cooldown4 = cooldown4 - 1;
		}
	}
}
