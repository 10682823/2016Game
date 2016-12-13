using UnityEngine;
using System.Collections;

public class QuadParallax : MonoBehaviour {

	public float speed = 0.5f;

	void Start (){

	}


	// Update is called once per frame
	void Update () {

		Vector2 offset = new Vector2(speed * Time.time, 0);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
	
	}
}
