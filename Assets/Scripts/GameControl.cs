using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]

public class GameControl : MonoBehaviour {

	public static GameControl instance;  

	public static int score = 0;
	public Text scoreText;
	public bool gameOver = false;
	public AudioSource playsource;
	public AudioClip balloonpop;
	public AudioClip ka, kha, ga, gha, ng;
	public static int letter;


	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
		AudioSource playsource = GetComponent<AudioSource> ();
		letter = (int)Random.Range (0f, 6f);

			if (letter == 1) {
			playsource.PlayOneShot (ga, 1f);
		} else if (letter == 2) {
			playsource.PlayOneShot (ka, 1f);
		} else if (letter == 3) {
			playsource.PlayOneShot (kha, 1f);
		} else if (letter == 4) {
			playsource.PlayOneShot (gha, 1f);
		} else if (letter == 5) {
			playsource.PlayOneShot (ng, 1f);
		} else {
	
		}
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void GameOver() {
		gameOver = true;
		SceneManager.LoadScene ("GameOvere", LoadSceneMode.Single);
	

	}

	public void ScoreUpdate() {
		if (gameOver)
			return;
		score++;
		scoreText.text = score.ToString();
	}

	public void PlayBalloonPop () {
		playsource.enabled = true;
		playsource.PlayOneShot (balloonpop);
		
	}

}
