using UnityEngine;
using System.Collections;


public class MovePlayer2 : MonoBehaviour 
{
	public float speed = 10f;
	private CharacterController controller;
	private Vector3 tempPosition;
	public float gravity = 3f;
	public float jumpSpeed = 30f;
	int AllowedJumps = 1; 
	int JumpCounter = 0;
	public int slideDuration = 100;
	public float slideTime = 0.1f;

	IEnumerator Slide()
	{
		int durationTemp = slideDuration;
		float speedTemp = speed;
		speed += speed;
		while (slideDuration > 0) 
		{
			slideDuration--;
			yield return new WaitForSeconds (slideTime);
		}
		speed = speedTemp;
		slideDuration = durationTemp;
	}

	void Start ()
	{
		//Add position reset function to MoveCamera delegate

		controller = GetComponent<CharacterController> ();
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			if (controller.isGrounded) 
			{
				tempPosition.y = jumpSpeed;
				JumpCounter = 0;
			}

			if (!controller.isGrounded && JumpCounter < AllowedJumps) 
			{
				tempPosition.y = jumpSpeed;
				JumpCounter++;
			}
		}
		tempPosition.y -= gravity;
		tempPosition.x = speed * Input.GetAxis ("Horizontal");
		controller.Move (tempPosition * Time.deltaTime);
		if(Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S))
		{
			StartCoroutine (Slide ());    
		}
		if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S))
		{
			StartCoroutine (Slide ());    
		}
	}

	//Make position reset function
}