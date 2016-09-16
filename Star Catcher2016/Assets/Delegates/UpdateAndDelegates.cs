using UnityEngine;
using System.Collections;
using System;



public class UpdateAndDelegates : MonoBehaviour {
    int health = 200;
    //actions are a type of delegate. Delegates contain functions just like vars contain data
    Action DisplayHealth;
    Action KillThePlayer;
    Action EndTheGame;

	// Use this for initialization
	void Start () {
        //we assign the function DisplayHealth to the action DisplayHealth
        DisplayHealth = DisplayHealthHandler;
	
	}
    
    void EndTheGameHandler ()
    {
        print("You didn't even try!");
        EndTheGame = null;
    }

    void KillThePlayerHandler ()
    {
        health--;
        print(health);
        if (health < 0)
        {
            KillThePlayer = null;
            EndTheGame = EndTheGameHandler;
        }
    }


    void DisplayHealthHandler ()
    {
        print("Health is Good");
        //we unassign all functions from display health
        DisplayHealth = null;
        KillThePlayer = KillThePlayerHandler;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //we chaeck if any function is assigned to DisplayHealth
        //if nothing is assigned DisplayHealth will not run
        if(DisplayHealth != null)
            DisplayHealth();

        if (KillThePlayer != null)
            KillThePlayer();

        if (EndTheGame != null)
            EndTheGame();
	}
}
