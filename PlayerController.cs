using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private SphereCollider rb;
	public static int count;
	private bool crash = true;
    private AudioSource audio;

    public AudioClip[] audioClip;

	void Start ()
	{
        audio = GetComponent<AudioSource>();    
		rb = GetComponent<SphereCollider>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

	
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
            PlaySound(0);
		}
		if (other.gameObject.CompareTag ("Crash") && crash)
		{
			count = count / 2;
			SetCountText ();
			crash = false;
            PlaySound(1);
		}
	}

    void PlaySound(int clip)
    {
        
        audio.PlayOneShot(audioClip[clip]);
    }

	void OnTriggerExit(Collider other){
		if (other.gameObject.CompareTag ( "Crash") && !crash)
		{
			crash = true;
		}
	
	}


	void SetCountText ()
	{
		countText.text = "SCORE: " + count.ToString ();
		if (count >= 20)
		{
			winText.text = "You Win!";
		}
	}
}