using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViolbladeFireTest : MonoBehaviour {

	public float maxVolume = 0.25f;
	public float volume = 0.5f;
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
	public GameObject projectileType1;
	public GameObject projectileType2;
	public GameObject projectileType3;
	public GameObject projectileType4;
	public GameObject projectileType5;
	public GameObject projectileType6;
	public GameObject projectileType7;
	public GameObject projectileType8;
	public GameObject projectileType9;
	public GameObject projectileType10;
	public GameObject projectileType11;
	public GameObject projectileType12;
	public GameObject projectileType13;
	public GameObject projectileType14;
	public GameObject player;
	public float cooldown1;
	public float cooldown2;
	public float cooldown3;
	public float cooldown4;
	public float cooldown5;
	public float cooldown6;
	public float cooldown7;
	public float cooldown8;
	public float cooldown9;
	public float cooldown10;
	public float cooldown11;
	public float cooldown12;
	public float cooldown13;
	public float cooldown14;
	public AudioSource g1;
	public AudioSource g2;
	public AudioSource g3;
	public AudioSource g4;
	public AudioSource g5;
	public AudioSource g6;
	public AudioSource g7;
	public AudioSource g8;
	public AudioSource g9;
	public AudioSource g10;
	public AudioSource g11;
	public AudioSource g12;
	public AudioSource g13;
	public AudioSource g14;

	void Start(){

		g1 = gun1R1.GetComponent<AudioSource> ();
		g2 = gun1R2.GetComponent<AudioSource> ();
		g3 = gun1R3.GetComponent<AudioSource> ();
		g4 = gun1L1.GetComponent<AudioSource> ();
		g5 = gun1L2.GetComponent<AudioSource> ();
		g6 = gun1L3.GetComponent<AudioSource> ();
		g7 = gun2R.GetComponent<AudioSource> ();
		g8 = gun2L.GetComponent<AudioSource> ();
		g9 = gun3R1.GetComponent<AudioSource> ();
		g10 = gun3R2.GetComponent<AudioSource> ();
		g11 = gun3R3.GetComponent<AudioSource> ();
		g12 = gun3L1.GetComponent<AudioSource> ();
		g13 = gun3L2.GetComponent<AudioSource> ();
		g14 = gun3L3.GetComponent<AudioSource> ();
	}

	void FixedUpdate () {

		var distx = Mathf.Abs (transform.position.x - player.transform.position.x);
		var disty = Mathf.Abs (transform.position.y - player.transform.position.y);
		var vol = ((100 - (distx + disty)) * volume) * Audio.volume;
		vol = Mathf.Clamp(vol, 0f, maxVolume);

		var p1 = projectileType1;
		var p2 = projectileType2;
		var p3 = projectileType3;
		var p4 = projectileType4;
		var p5 = projectileType5;
		var p6 = projectileType6;
		var p7 = projectileType7;
		var p8 = projectileType8;
		var p9 = projectileType9;
		var p10 = projectileType10;
		var p11 = projectileType11;
		var p12 = projectileType12;
		var p13 = projectileType13;
		var p14 = projectileType14;

		var pc1 = p1.GetComponent<BoltProjectile> ().coolDown;
		var pc2 = p2.GetComponent<BoltProjectile> ().coolDown;
		var pc3 = p3.GetComponent<BoltProjectile> ().coolDown;
		var pc4 = p4.GetComponent<BoltProjectile> ().coolDown;
		var pc5 = p5.GetComponent<BoltProjectile> ().coolDown;
		var pc6 = p6.GetComponent<BoltProjectile> ().coolDown;
		var pc7 = p7.GetComponent<BoltProjectile> ().coolDown;
		var pc8 = p8.GetComponent<BoltProjectile> ().coolDown;
		var pc9 = p9.GetComponent<BoltProjectile> ().coolDown;
		var pc10 = p10.GetComponent<BoltProjectile> ().coolDown;
		var pc11 = p11.GetComponent<BoltProjectile> ().coolDown;
		var pc12 = p12.GetComponent<BoltProjectile> ().coolDown;
		var pc13 = p13.GetComponent<BoltProjectile> ().coolDown;
		var pc14 = p14.GetComponent<BoltProjectile> ().coolDown;

		var sound1 = p1.GetComponent<BoltProjectile> ().sound;
		var sound2 = p2.GetComponent<BoltProjectile> ().sound;
		var sound3 = p3.GetComponent<BoltProjectile> ().sound;
		var sound4 = p4.GetComponent<BoltProjectile> ().sound;
		var sound5 = p5.GetComponent<BoltProjectile> ().sound;
		var sound6 = p6.GetComponent<BoltProjectile> ().sound;
		var sound7 = p7.GetComponent<BoltProjectile> ().sound;
		var sound8 = p8.GetComponent<BoltProjectile> ().sound;
		var sound9 = p9.GetComponent<BoltProjectile> ().sound;
		var sound10 = p10.GetComponent<BoltProjectile> ().sound;
		var sound11 = p11.GetComponent<BoltProjectile> ().sound;
		var sound12 = p12.GetComponent<BoltProjectile> ().sound;
		var sound13 = p13.GetComponent<BoltProjectile> ().sound;
		var sound14 = p14.GetComponent<BoltProjectile> ().sound;

		var pr1 = gun1R1.transform.position;
		var pr2 = gun1R2.transform.position;
		var pr3 = gun1R3.transform.position;
		var pl1 = gun1L1.transform.position;
		var pl2 = gun1L2.transform.position;
		var pl3 = gun1L3.transform.position;
		var sr = gun2R.transform.position;
		var sl = gun2L.transform.position;
		var tr1 = gun3R1.transform.position;
		var tr2 = gun3R2.transform.position;
		var tr3 = gun3R3.transform.position;
		var tl1 = gun3L1.transform.position;
		var tl2 = gun3L2.transform.position;
		var tl3 = gun3L3.transform.position;
		var m = transform.rotation;

		if (cooldown1 <= 0) {
			Instantiate (projectileType1, pr1, m);
			cooldown1 = pc1;
			g1.PlayOneShot (sound1, vol);
			
		} else {
			cooldown1 = cooldown1 - 1;
		}

		if (cooldown2 <= 0) {
			Instantiate (projectileType2, pr2, m);
			cooldown2 = pc2;
			g2.PlayOneShot (sound2, vol);
			
		} else {
			cooldown2 = cooldown2 - 1;
		}

		if (cooldown3 <= 0) {
			Instantiate (projectileType3, pr3, m);
			cooldown3 = pc3;
			g3.PlayOneShot (sound3, vol);
			
		} else {
			cooldown3 = cooldown3 - 1;
		}

		if (cooldown4 <= 0) {
			Instantiate (projectileType4, pl1, m);
			cooldown4 = pc4;
			g4.PlayOneShot (sound4, vol);
			
		} else {
			cooldown4 = cooldown4 - 1;
		}

		if (cooldown5 <= 0) {
			Instantiate (projectileType5, pl2, m);
			cooldown5 = pc5;
			g5.PlayOneShot (sound5, vol);

		} else {
			cooldown5 = cooldown5 - 1;
		}

		if (cooldown6 <= 0) {
			Instantiate (projectileType6, pl3, m);
			cooldown6 = pc6;
			g6.PlayOneShot (sound6, vol);

		} else {
			cooldown6 = cooldown6 - 1;
		}

		if (cooldown7 <= 0) {
			Instantiate (projectileType7, sr, m);
			cooldown7 = pc7;
			g7.PlayOneShot (sound7, vol);

		} else {
			cooldown7 = cooldown7 - 1;
		}

		if (cooldown8 <= 0) {
			Instantiate (projectileType8, sl, m);
			cooldown8 = pc8;
			g8.PlayOneShot (sound8, vol);

		} else {
			cooldown8 = cooldown8 - 1;
		}

		if (cooldown9 <= 0) {
			Instantiate (projectileType9, tr1, m);
			cooldown9 = pc9;
			g9.PlayOneShot (sound9, vol);

		} else {
			cooldown9 = cooldown9 - 1;
		}

		if (cooldown10 <= 0) {
			Instantiate (projectileType10, tr2, m);
			cooldown10 = pc10;
			g10.PlayOneShot (sound10, vol);

		} else {
			cooldown10 = cooldown10 - 1;
		}

		if (cooldown11 <= 0) {
			Instantiate (projectileType11, tr3, m);
			cooldown11 = pc11;
			g11.PlayOneShot (sound11, vol);

		} else {
			cooldown11 = cooldown11 - 1;
		}

		if (cooldown12 <= 0) {
			Instantiate (projectileType12, tl1, m);
			cooldown12 = pc12;
			g12.PlayOneShot (sound12, vol);

		} else {
			cooldown12 = cooldown12 - 1;
		}

		if (cooldown13 <= 0) {
			Instantiate (projectileType13, tl2, m);
			cooldown13 = pc13;
			g13.PlayOneShot (sound13, vol);

		} else {
			cooldown13 = cooldown13 - 1;
		}

		if (cooldown14 <= 0) {
			Instantiate (projectileType14, tl3, m);
			cooldown14 = pc14;
			g14.PlayOneShot (sound14, vol);

		} else {
			cooldown14 = cooldown14 - 1;
		}
	}
}
