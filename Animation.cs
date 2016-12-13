using UnityEngine;

using System.Collections;

public class Animation : MonoBehaviour {

	MoveCharacter myMoveCharacter;

	public Animator myAnimator;

	private float _h;

	//  private float _v;

	void Start () {

		myMoveCharacter = new MoveCharacter ();

		myAnimator = GetComponent<Animator> ();

		myMoveCharacter.mycc = GetComponent<CharacterController> ();

	}

	void Update () {

		_h = Mathf.Abs (myMoveCharacter.mycc.velocity.x);

		myAnimator.SetFloat ("Speed", _h);

		if (!myMoveCharacter.mycc.isGrounded) {

			myAnimator.SetLayerWeight (1, 1);

			//myAnimator.SetBool ("Landing", true);

		}

		else {

			myAnimator.SetLayerWeight (1, 0);

			myAnimator.SetBool ("Jump", false);

			myAnimator.SetBool ("DoubleJump",false);

			//myAnimator.SetBool ("Landing", false);

		}

		if (Input.GetKeyDown (KeyCode.Space)) {

			if (myMoveCharacter.mycc.isGrounded) {

				myAnimator.SetBool ("Jump", true);

			}

			if (!myMoveCharacter.mycc.isGrounded && myMoveCharacter.jumpCount < myMoveCharacter.jumpCountMax) {

				myAnimator.SetBool ("Jump", false);

				myAnimator.SetBool ("DoubleJump",true);

			}

		}

	}



}

