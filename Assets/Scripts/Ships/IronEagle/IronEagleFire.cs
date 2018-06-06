using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronEagleFire : MonoBehaviour {

	public GameObject gun1R;
	public GameObject gun1L;
	public GameObject gun2R;
	public GameObject gun2L;

	void FirePrimary () {

			gun1R.SendMessage ("Fire");
			gun1L.SendMessage ("Fire");
			gun2R.SendMessage ("Fire");
			gun2L.SendMessage ("Fire");
		
	}
}