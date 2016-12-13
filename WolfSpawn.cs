using UnityEngine;
using System.Collections;

public class WolfSpawn : MonoBehaviour {

	public GameObject wolfRef;
	public float wolfSpawnChance;
	public Transform cameraPosition;
	private Vector3 tempPos;
	public EnemyMove moveScript;


	private const float X_OFFSET = 30;
	private const float Y_OFFSET = 1;

	public bool wolfReady = true;

	public EnemyMove wolfScript;


	// Use this for initialization
	void Start () 
	{
		StartCoroutine (Spawn());
	}

		IEnumerator Spawn()
	{
		while (true) {
			yield return new WaitForSeconds (1);
			if (wolfSpawnChance > UnityEngine.Random.Range (0, 100) && wolfReady) {
				tempPos = cameraPosition.transform.position;
				tempPos.z = 0;
				tempPos.y += Y_OFFSET;

				wolfRef.SetActive (true);

				if (UnityEngine.Random.Range (0, 100) > 50) {
					tempPos.x -= X_OFFSET;
					wolfScript.SetDirection (true);
				} 
				else 
				{
					tempPos.x += X_OFFSET;
					wolfScript.SetDirection (false);
				}



				wolfRef.transform.position = tempPos;

				moveScript.WolfRunning = true;
				StartCoroutine (moveScript.MoveHandler ());
				wolfReady = false;

			}	
		}
	}
}
	


