using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {

    //This is the character Controller Component
    private CharacterController mycc;

    //Temp bar of datatype vactor3 to move the character
    private Vector3 tempPos;

    //speed of temp var in x
    public float speed = 1;
    public float gravity = 1;
    public float jumpSpeed = 1;
    public int jumpCount = 0;
    public int jumpCountMax = 2;

	// Use this for initialization
	void Start () {
        //This finds the character component
        mycc = GetComponent<CharacterController>();
	
	}

    // Update is called once per frame
    void Update() {

     
        //waiting for input and comparing jumpcount
        if (Input.GetKeyDown(KeyCode.Space) &&jumpCount < jumpCountMax-1)
        {
            //incrementing the jumpcount by 1
            jumpCount++;
            //adding the jump speed var to the tempPos var
            tempPos.y = jumpSpeed;
        }
            //test if the character controller is grounded
            if(mycc.isGrounded)
        {
            //reset jumpcount if grounded
            jumpCount = 0;
        }
            //adding the gravity var to y position of the tempPos var
            tempPos.y -= gravity;
            //adding the speed var to the tempPos var x value with the right and left arrow keys
            tempPos.x = speed * Input.GetAxis("Horizontal");
            //moves teh character controller at an evan pace (deltaTime)
            mycc.Move(tempPos * Time.deltaTime);

        }
 }