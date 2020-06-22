using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenuControllerScript : MonoBehaviour {

	public void GoBack() { 
		SceneManager.LoadScene ("MainMenuScene", LoadSceneMode.Single);
	}
}
