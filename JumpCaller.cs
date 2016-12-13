using UnityEngine;
using System.Collections;

public class JumpCaller : MonoBehaviour {

	public EnemyMove myScript;

	void OnTriggerEnter()
	{
		myScript.jumpHandler ();
	}

}
