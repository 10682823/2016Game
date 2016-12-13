using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddName : MonoBehaviour {

	public Text myText;

	void Start()
	{
		print ("Hello" + PlayerPrefs.GetString ("PLayerName"));
	}

	// Use this for initialization
	public void NameThis () {
		PlayerPrefs.SetString("Player Name", myText.text);
		print (PlayerPrefs.GetString ("PlayerName"));
	
	}
}
