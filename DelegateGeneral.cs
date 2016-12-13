using UnityEngine;
using System.Collections;
using System;

public class DelegateGeneral : MonoBehaviour {

	Action<int> Move;
	Action Idle;
	Action Jump;


	void MoveHandler (int _speed)
	{
		print ("moving at" + _speed + "mph");
		Move = null;
		Idle = IdleHandler;

	}
	void IdleHandler ()
	{
		print ("idle");
		Idle = null;
		Jump = JumpHandler;

	}
	void JumpHandler ()
	{
		print ("jump");
		Jump = null;
	

	}


	// Use this for initialization
	void Start () {
		Move = MoveHandler;

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Move != null)
			Move (50);
		if (Idle != null)
			Idle ();
		if (Jump != null)
			Jump ();
	
	}
}
