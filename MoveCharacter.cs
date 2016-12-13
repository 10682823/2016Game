using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {

    //This is the character Controller Component
    public CharacterController mycc;

    //Temp bar of datatype vactor3 to move the character
    private Vector3 tempPos;

    //speed of temp var in x
    public float speed = 1;
    public float gravity = 1;
    public float jumpSpeed = 1;
    public int jumpCount = 0;
    public int jumpCountMax = 2;
    //sliding vars
    public int slideDuration = 100;
    public float slideTime = 0.01f;
    //coroutine for sliding the character
    IEnumerator Slide ()
    {
        //set a temp var to the value of slideDuration
        int durationTemp = slideDuration;
        //
        float speedTemp = speed;
        speed += speed;
        //While loop runs "while" the slideDuration is greater than 0
        while (slideDuration > 0)
        {
            
            //decrement the slideDuration
            slideDuration--;
            //yield "hold the corountine"
            //return "sends" to the corountine to do an opperation while yielding
            //new creates an instance of an object
            //WaitFor Seconds is an object that waits for a duation of time
            yield return new WaitForSeconds(slideTime);
            
        }
        speed = speedTemp;
        slideDuration = durationTemp;
    }
	void StartGameHandler ()
	{
		//MoveUsingArrowKeys.MoveOnArrows += MoveCamera;
		GameControl.StartGame += StartGameHandler;
	}

    // Use this for initialization
    void Start () {
        //This finds the character component
		//EndGame.GameOver += StopScript;
        mycc = GetComponent<CharacterController>();
		GameControl.StartGame += StartGameHandler;
	
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
        //start sliding
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S))
        {
            //StartCoroutine is a function that calls a coroutine. Use the coroutine in the argument
            StartCoroutine(Slide());
        }
            //start sliding
            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S))
            {
                //StartCoroutine is a function that calls a coroutine. Use the coroutine in the argument
                StartCoroutine(Slide());
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