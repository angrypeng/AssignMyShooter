using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfScreen : MonoBehaviour {

	void OnTriggerEnter(Collider coll){
		Debug.Log ("hi?");
		if (coll.transform.tag == "Laser") {
			Debug.Log ("ha");
			Destroy (coll.gameObject);
		}
	}

	void OnCollisionEnter(Collision coll){
		Debug.Log ("what");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
