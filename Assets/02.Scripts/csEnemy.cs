using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csEnemy : MonoBehaviour {

	public float moveSpeed = 0.5f;
	public GameObject explosionPrefab;

	int killScore = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MoveEnemy ();
	}

	void MoveEnemy(){
		float yMove = moveSpeed * Time.deltaTime;
		transform.Translate (0, -yMove, 0);
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			Instantiate (explosionPrefab, transform.position, Quaternion.identity);
			SoundManager.Instance ().PlaySound ();
			Destroy (coll.gameObject);
			Destroy (gameObject);
		} else if (coll.gameObject.tag == "Laser") {
			Instantiate (explosionPrefab, transform.position, Quaternion.identity);
			SoundManager.Instance ().PlaySound ();
			GameManager.Instance ().AddScore (killScore);

			Destroy (coll.gameObject);
			Destroy (gameObject);
		}
	}
}
