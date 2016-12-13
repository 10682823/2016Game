	using UnityEngine;
	using UnityEngine.UI;
	using System.Collections;
	using UnityEngine.SceneManagement;


	public class Restart : MonoBehaviour

	{

		public GameObject gameOverText;
		public GameObject EndGameScreen;
		public GameObject star;
		public Text text;
		public Text starCount;
		public int timeUpFont = 150;
		public GameObject player;
        private AudioSource audio;

        public int wait = 30;

    public AudioClip[] audioClip;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public IEnumerator IGameOverText()

		{

			star.SetActive(false);

			text.enabled = false;

			starCount.enabled = false;

			gameOverText.SetActive(true);

			yield return new WaitForSeconds(timeUpFont * Time.deltaTime);

			EndGameScreen.SetActive(true);

            PlaySound(2);

        player.SetActive(false);
     
    }

    void PlaySound(int clip)
    {

        audio.PlayOneShot(audioClip[clip]);
    }



    void OnTriggerEnter()

		{

			//StartCoroutine(IGameOverText());

		}

	}