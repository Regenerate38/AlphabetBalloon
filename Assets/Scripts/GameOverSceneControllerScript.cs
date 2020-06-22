using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]


public class GameOverSceneControllerScript : MonoBehaviour {

	public AudioClip gameoverclip;
	public static int highscore;
	public int scorefromgame;
	public Text HighScoreText;


	void Start() {
		AudioSource gameoversource;
		gameoversource = GetComponent<AudioSource> ();	
		gameoversource.enabled = true;
		gameoversource.PlayOneShot (gameoverclip);

		scorefromgame = GameControl.score;
		if (scorefromgame > highscore) {
			highscore = scorefromgame;
			HighScoreText.text = "HIGH SCORE: " + scorefromgame.ToString ();
		} else {
			HighScoreText.text = "HIGH SCORE:" + highscore.ToString ();
			
		}

	}



	public void StartGame() {
		SceneManager.LoadScene ("MainScene", LoadSceneMode.Single);
	}
	public void BackToMenu() {
		SceneManager.LoadScene ("MainMenuScene", LoadSceneMode.Single);
	}
}
