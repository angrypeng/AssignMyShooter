using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csLaser : MonoBehaviour {

	public float moveSpeed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float moveY = moveSpeed * Time.deltaTime;
		transform.Translate (0, moveY, 0);
	}

	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
