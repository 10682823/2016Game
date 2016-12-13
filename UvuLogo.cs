using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UvuLogo : MonoBehaviour {

	public int TimeUpFont = 10;
	public Canvas logo;

	// Use this for initialization
	public IEnumerator FadeOutLogo()
	{
		yield return new WaitForSeconds (TimeUpFont);
		logo.enabled = false;

	
	}
	
	// Update is called once per frame
	void Start () {
	
		StartCoroutine(FadeOutLogo());

	}
}
