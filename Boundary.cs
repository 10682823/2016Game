using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boundary : MonoBehaviour {


	void OnTriggerEnter ()
	{
		RestartLevel ();
	
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene (0);
	}
}
