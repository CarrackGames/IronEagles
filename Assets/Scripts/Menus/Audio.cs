using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour {
	public static float volume;
	public Slider maxVol;

	void Start () {
		volume = 0.5f;
	}

	void Update () {
		volume = maxVol.value;
	}
}
