using UnityEngine;
using System.Collections;
using System;

public class GameControl : MonoBehaviour {

	public static Action StartGame;
	public static Action EndGame;

	public void StartGameCall ()
	{
		print ("StartGame");
		if (StartGame != null)
			StartGame ();
	
	}
}
