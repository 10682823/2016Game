using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	public float speed = -1f;
	private Vector3 tempPos;

	void Update () 
	{
		MoveCamera ();    
	}

	void MoveCamera()
	{
		tempPos.x = speed * Time.deltaTime;
		transform.Translate (tempPos);
	}
}