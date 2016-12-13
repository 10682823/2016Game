using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour 
{

	public float speed;
	public float gravity;
	public float jumpstrength;
	private Vector3 movement;
	private CharacterController myCC;
	private Vector3 tempPos;
	public bool WolfRunning = true;
	public Transform charArt;
	private bool forward = true;


	// Use this for initialization
	void Start () {
		Debug.Log("running");
		myCC = GetComponent<CharacterController> ();
		movement = new Vector3 (speed, 0, 0);
		//StartCoroutine(MoveHandler());
			
	}

	public void jumpHandler()
	{
		movement.y = jumpstrength;
	}




	public IEnumerator MoveHandler()
	{
		
		while (WolfRunning) 
		{
			yield return new WaitForSeconds (.02f);



			movement.y -= gravity * Time.deltaTime;
			myCC.Move (movement * Time.deltaTime);

			/*if (movement.y > (gravity * 5)) 
			{
				movement.y = gravity * 5;
			}*/

			if (transform.position.z != 0) 
			{
				tempPos = transform.position;
				tempPos.z = 0;
				transform.position = tempPos;
			}
		}
	}


	public void SetDirection(bool runRight)
	{
		if (runRight)
		{
			movement = new Vector3 (speed, 0, 0);
			if (!forward) 
			{
				charArt.Rotate (0, 180, 0);
				forward = true;
			}
		}
		else
		{
			movement = new Vector3 (-speed, 0, 0);
			if (forward) 
			{
				charArt.Rotate (0, 180, 0);
				forward = false;
			}
		}
	
	
	}

}
