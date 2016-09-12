using UnityEngine;
using System.Collections;

public class ForEach : MonoBehaviour {

    public string[] powerUps = { "Health", "Ammo", "Magic", "Sheilds" };

	// Use this for initialization
	void Start () {
        foreach (string _powerUp in powerUps)
        {
            print("I found a " + _powerUp + " power-up on the way to grandmas.");
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
