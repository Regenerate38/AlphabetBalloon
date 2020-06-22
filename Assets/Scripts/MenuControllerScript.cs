using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllerScript : MonoBehaviour {

	// Use this for initialization
	public void StartGame() {
		SceneManager.LoadScene ("MainScene", LoadSceneMode.Single);
	}
	public void EndGame() {
		Application.Quit ();
	}
	public void LoadOptions() {
		SceneManager.LoadScene ("OptionsMenuScene", LoadSceneMode.Single);	
	}
}
