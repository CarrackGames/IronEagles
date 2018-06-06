using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDelay : MonoBehaviour {
	public GameObject delayedAnim;
	public float delay = 50f;

	void FixedUpdate () {
		if (delay <= 0) {
			delayedAnim.SetActive (true);
		} else {
			delay = delay - 1;
		}
	}
}
