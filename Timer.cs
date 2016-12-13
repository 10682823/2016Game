using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour 
{
	public float timeLeft = 30.0f;
	//public float myTimer = 30;
	public Text timerText;


	// Use this for initialization
	void Start ()
	{
		timerText = GetComponent<Text>();

        StaticVars.nextSectionPos = StaticVars.startPos;
       
    }

	// Update is called once per frame
	void Update () 
	{
		//myTimer -= Time.deltaTime;
		timerText.text = ("TIME: " + timeLeft.ToString("f2"));

		timeLeft -= Time.deltaTime;
		if ( timeLeft < 0 )
		{
			SceneManager.LoadScene (2);

		}

	}
}
