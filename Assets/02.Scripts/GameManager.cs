using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	static GameManager _instance = null;

	int score = 0;
	public Text scoreText;
	public GameObject readyText;

	public static GameManager Instance(){
		return _instance;
	}

	// Use this for initialization
	void Start () {
		if (_instance == null) {
			_instance = this;
		}

		Invoke ("StartGame", 3.0f);
		readyText.SetActive (false);
		StartCoroutine (showReady ());
	}

	void StartGame(){
		csPlayer.canShoot = true;
		SpawnManager.isSpawn = true;
	}

	IEnumerator showReady(){
		int count = 0;
		while (count < 3) {
			readyText.SetActive (true);
			yield return new WaitForSeconds (0.5f);

			readyText.SetActive (false);
			yield return new WaitForSeconds (0.5f);
			count++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore(int score){
		this.score += score;
		scoreText.text = "Score : " + this.score;
	}
}
