using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class Grounding : MonoBehaviour {

	public Vector3 startPoint;
	private CharacterController cc;
	public float gravity = 1;
	private Vector3 tempP;
	public float speed = 1;

	// Use this for initialization
	void Start () {
		startPoint = transform.position;
		cc = GetComponent<CharacterController>();
	}

	void OnTriggerEnter ()
	{

		speed *= -1;
		//transform.position = startPoint;
	}
	
	// Update is called once per frame
	void Update () {
		print (cc.velocity);
		tempP.y = -gravity;
		cc.Move (tempP * Time.deltaTime);
		if (cc.isGrounded) {
			tempP.x = speed;
		} else {
			tempP.x = 0;
		}
			
	}
}

//square, cc, grounding script
