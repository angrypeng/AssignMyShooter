using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csBackScroll : MonoBehaviour {

	public float scrollSpeed = 0.8f;
	Material myMaterial;

	// Use this for initialization
	void Start () {
		myMaterial = GetComponent<Renderer> ().material;
	}
	
	// Update is called once per frame
	void Update () {
		float newOffSetY = myMaterial.mainTextureOffset.y +
		                   scrollSpeed * Time.deltaTime;
		Vector2 newOffSet = new Vector2 (0, newOffSetY);
		myMaterial.mainTextureOffset = newOffSet;
	}
}
