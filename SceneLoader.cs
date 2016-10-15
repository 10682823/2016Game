using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	void OnTriggerEnter ()
	{
		RestartLevel ();
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene (1);
	}

	public void StartGame (){
		SceneManager.LoadScene (0);
			
	}
}
