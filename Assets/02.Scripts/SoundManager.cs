using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	static SoundManager _instance = null;

	public AudioClip sndExplosion;
	AudioSource myAudio;

	public static SoundManager Instance(){
		return _instance;
	}

	// Use this for initialization
	void Start () {
		if (_instance == null) {
			_instance = this;
		}

		myAudio = GetComponent<AudioSource> ();
	}

	public void PlaySound(){
		myAudio.PlayOneShot (sndExplosion);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
