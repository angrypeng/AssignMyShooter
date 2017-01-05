using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {

	public static bool gamePause = false;
	public Texture2D pauseButtonImg;

	void OnGUI(){
		PauseStateProcess ();
		DrawPauseText ();
	}

	void PauseStateProcess(){
		int width = pauseButtonImg.width;
		int height = pauseButtonImg.height;

		if (GUI.Button (new Rect (Screen.width - 74.0f, 10,
			   width, height), pauseButtonImg, GUIStyle.none)) {
			gamePause = !gamePause;

			if (gamePause == true)
				Time.timeScale = 0.0f;
			else
				Time.timeScale = 1.0f;
		}
	}

	void DrawPauseText(){
		if (gamePause) {
			
			float x = Screen.width/ 2.0f;
			float y = Screen.height /2.0f;

			if(GUI.Button( new Rect (x -30, y + 50, 100, 50), " Restart ")){
				Time.timeScale = 1.0f;
				gamePause = false;

			}

			if (GUI.Button (new Rect (x - 30, y - 50, 100, 50), " Exit ")) {
				SceneManager.LoadScene ("Title");
			}
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
