using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boundary : MonoBehaviour {


    private AudioSource audio;

    public AudioClip[] audioClip;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        StaticVars.nextSectionPos = StaticVars.startPos;
    }

        void OnTriggerEnter ()
	{
		RestartLevel ();
        PlaySound(0);

    }

	public void RestartLevel()
	{
		SceneManager.LoadScene (0);
	}


    void PlaySound(int clip)
    {

        audio.PlayOneShot(audioClip[clip]);
    }
}
