using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnScript : MonoBehaviour {

	public GameObject balloon1;
	public GameObject balloon2;
	public GameObject balloon3;
	public GameObject balloon4;
	public GameObject balloon5;
	float randX;
	int randomballoon;
	Vector2 wheretospawn;
	public float spawnRate = 5f;
	float nextspawn = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextspawn) {
			nextspawn = Time.time + spawnRate;
			randX = Random.Range (-2f, 2f);
			randomballoon = Random.Range (0, 5);
			wheretospawn = new Vector2 (randX, transform.position.y);
			if (randomballoon == 1) { 
				Instantiate (balloon1, wheretospawn, Quaternion.identity);
			} else if (randomballoon == 2) { 
				Instantiate (balloon2, wheretospawn, Quaternion.identity);
			} else if (randomballoon == 3) { 
				Instantiate (balloon3, wheretospawn, Quaternion.identity);
			} else if (randomballoon == 4){
				Instantiate (balloon4, wheretospawn, Quaternion.identity);

			}else {
				Instantiate (balloon5, wheretospawn, Quaternion.identity);
			}
		}
	}
}
