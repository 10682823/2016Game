﻿using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

    public float speed = 10;
    //Used to move the player
    private CharacterController controller;
    public float gravity = -9.81f;

    //Use to assign location as a temp var
    private Vector3 tempPosition;



	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();

	
	}
	
	// Update is called once per frame
	void Update () {

        //Fake gravity
        tempPosition.y = gravity;
        //Using Axis as an input with speed the character can hold or move left or right
        tempPosition.x = speed*Input.GetAxis("Horizontal");
        tempPosition *= Time.deltaTime;
        //Move method takes the temp vactor3 to move
        controller.Move(tempPosition);
        
	    
	}
}
