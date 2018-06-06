using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThenDelete : MonoBehaviour {

	public float speed;
	public float lifeTime;

	void FixedUpdate () {

		transform.Translate (0, speed, 0);

		if (lifeTime <= 0) {
			Destroy (gameObject);
		} else {
			lifeTime = lifeTime - 1;
		}
	}
}
