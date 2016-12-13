using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour {

	public int forceTime =10;
	public float forceDuration = 0.1f;
	private bool canAddForce = true;
	private Rigidbody rigid;
	private float force;
	public float forceRange = 150;
	private Vector3 forceVector;
	private Vector3 torqueVector;
	public Transform Storage;


	void Start()
	{
		rigid = GetComponent<Rigidbody>();
		RespawnHandler ();
		//CloneStar.respawned += RespawnHandler;
	}
	public void RespawnHandler(){
		forceDuration += 0.1f;
		StartCoroutine(RunRandomForce());
			}
	IEnumerator RunRandomForce()
	{
		force = Random.Range(-forceRange, forceRange);
		while (forceTime > 0) 
		{
			
			yield return new WaitForSeconds(forceDuration);
			forceVector.x = force;
			torqueVector.z = force/force;
			rigid.AddTorque (torqueVector);
			rigid.AddForce (forceVector);
			forceTime--;

		}
	}

	public float endTime = 3;

	void OnCollisionEnter () {
		canAddForce = false;
		Destroy (gameObject, endTime);
	}
	void OnDestroy(){
		CloneStar.respawned -= RespawnHandler;
	}
	/*IEnumerator EndStar ()
	{
		yield return new WaitForSeconds(endTime);

	}
	*/
}
