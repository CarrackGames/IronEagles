using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuQuit : MonoBehaviour {

	public void OnGoMainMenuClick(){
		SceneManager.LoadSceneAsync ("MainMenu");
	}
	
	public void OnClick () {
		Application.Quit ();
	}
}
