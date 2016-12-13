/**using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	Vector3 Move;

	// Use this for initialization
	void Start () {
		myCC = GetComponent<CharacterController> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		tempPos.y -= gravity*Time.deltaTime;
		temPos.z = sideForce;

		if (myCC.isGrounded) {
			tempPos.y = 0;
		}
		print (myCC.velocity);
		myCC.Move (tempPos);
			
	}
}

**/
