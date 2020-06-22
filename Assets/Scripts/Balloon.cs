using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Balloon : MonoBehaviour {

	public float floatStrength = 0.5f;
	public Sprite Boom;
	public int mainletter;
	string requiredballoon;


	// Use this for initialization
	void Start () {

		mainletter = GameControl.letter;
		if (mainletter == 1) {
			requiredballoon = "Balloon1";
		} else if (mainletter == 2) {
			requiredballoon = "Balloon2";
		} else if (mainletter == 3) {
			requiredballoon = "Balloon3";
		} else if (mainletter == 4) {
			requiredballoon = "Balloon4";
		} else if (mainletter == 5) {
			requiredballoon = "Balloon5";
		} else {
			requiredballoon = "Balloon1";	
			}
	
			
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Rigidbody2D> ().AddForce (Vector3.up * floatStrength);
		if (this.gameObject.tag == requiredballoon) {
			if (transform.position.y >= 5) {
				GameControl.instance.GameOver();
			}
		}
		}

	 void OnMouseDown(){
		
		StartCoroutine (Example ());

	}
	IEnumerator Example() {
		
		if (this.gameObject.tag == requiredballoon) {


			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Boom;
			yield return new WaitForSeconds (0.05f);
			Destroy (this.gameObject);
			GameControl.instance.ScoreUpdate();
			GameControl.instance.PlayBalloonPop ();
		}
		else {
			Debug.Log ("This isn't the required Balloon");
			GameControl.instance.GameOver();
		}
		}		
		


		
}