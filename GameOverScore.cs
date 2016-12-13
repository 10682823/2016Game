using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScore : MonoBehaviour {

	public Text egScore;



	// Use this for initialization
	void Start () {

		egScore.text = ("SCORE: " + PlayerController.count);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
