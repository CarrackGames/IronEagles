using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViolbladeFire : MonoBehaviour {

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

	void FirePrimary () {

		gun1R1.SendMessage ("Fire");
		gun1R2.SendMessage ("Fire");
		gun1R3.SendMessage ("Fire");
		gun1L1.SendMessage ("Fire");
		gun1L2.SendMessage ("Fire");
		gun1L3.SendMessage ("Fire");
		gun3R1.SendMessage ("Fire");
		gun3R2.SendMessage ("Fire");
		gun3R3.SendMessage ("Fire");
		gun3L1.SendMessage ("Fire");
		gun3L2.SendMessage ("Fire");
		gun3L3.SendMessage ("Fire");
		gun2R.SendMessage ("Fire");
		gun2L.SendMessage ("Fire");
	}
}
