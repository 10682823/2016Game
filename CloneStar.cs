using UnityEngine;
using System.Collections;
using System;

public class CloneStar : MonoBehaviour {
	public static Action respawned;
	public Transform[] spawnPoints;
	public Transform star;
	public float spawnFrequency = 1;
	public bool canSpawnStars = true;

	private int i;

	IEnumerator SpawnStars ()
	{
		
			

			Instantiate (star, spawnPoints[i].position, Quaternion.identity);
			
			yield return new WaitForSeconds(spawnFrequency);
			//respawned();
			Start ();


	}

	// Use this for initialization
	void Start () {
		i = UnityEngine.Random.Range (0, spawnPoints.Length - 1);
		StartCoroutine(SpawnStars());

	}
}
