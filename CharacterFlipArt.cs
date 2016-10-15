using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour
{
	//public Transform characterArt;
	public bool forward = false;

	void FlipCharacter (KeyCode _keyCode)
	{
		switch (_keyCode) {
		case KeyCode.RightArrow:
			if (forward) {
				transform.Rotate (0, 180, 0);


				forward = false;


			}
			break;

		case KeyCode.LeftArrow:
			if (!forward) {
				transform.Rotate (0, 180, 0);


				forward = true;
			}
			break;
		}
		// forward = _b;

	}

	//Use this for initialization
	void Start ()
	{
		UserInputs.UserInput += FlipCharacter;

	}

	//update is called once per frame
	void OnDestroy ()
	{
		UserInputs.UserInput -= FlipCharacter;
	}
}

