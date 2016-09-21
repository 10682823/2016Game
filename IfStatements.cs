using UnityEngine;
using System.Collections;
using System;

public class IfStatements : MonoBehaviour {

    public bool isDoorUnlocked = false;


    // Use this for initialization
    void OnMouseDown () {
        if (isDoorUnlocked)
        {
            Enter();
        }
        else
        {
            Exit();
        } 
	
	}
    private void Exit()
    {
        print("The way is shut - He is coming!");
    }

    private void Enter()
    {
        print("Speak friend and enter");
    }
}
