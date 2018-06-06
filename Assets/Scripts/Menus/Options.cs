using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour {
	public GameObject optionsMenu;
	public GameObject otherMenu1;
	public GameObject otherMenu2;

	public void OnXClick(){
		optionsMenu.SetActive (false);
	}

	public void OnOptionsClick(){
		optionsMenu.SetActive (true);
	}

	public void OnInOptionsClick(){
		otherMenu1.SendMessage ("Close");
		otherMenu2.SendMessage ("Close");
		optionsMenu.SetActive (true);
	}

	void Close(){
		optionsMenu.SetActive (false);
	}
}
