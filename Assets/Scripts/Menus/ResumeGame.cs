using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour {
	public GameObject pauseMenu;

	public void OnButton() {
		pauseMenu.SetActive (false);
		PlayerController.paused = false;
		Time.timeScale = 1;
	}
}
