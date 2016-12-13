using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StaticVars.score = 0;
		StartCoroutine (AddToScore ());
	
	}
	
	IEnumerator AddToScore ()
	{
		StaticVars.score++;
		yield return new WaitForSeconds(1);
		print(StaticVars.score);
		StartCoroutine(AddToScore());

	}

	void OnDisable()
	{
		//PlayerPrefs.GetInt ("Score", StaticVars.score);
		print ("Final Score:" + PlayerPrefs.GetInt ("SCORE"));
		print ("GameOver");
	}
}
