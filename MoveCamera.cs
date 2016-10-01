using UnityEngine;
using System.Collections;
using System;

public class MoveCamera : MonoBehaviour {

	//Make new delegate


    public float speed = 5;
    private Vector3 tempPos;

	void Start()
	{
		//Add position reset function to delegate
		
	}
	
	// Update is called once per frame
	void Update () {
        tempPos.x = speed * Time.deltaTime;
        transform.Translate(tempPos);
	}

	//Make function to reset camera's position
}
