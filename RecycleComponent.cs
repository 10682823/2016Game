using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleComponent : MonoBehaviour 
{

	private Vector3 tempPos;
	private Vector3 newLocation;

	void OnTriggerEnter ()
	{
		newLocation.x = StaticVars.nextSectionPos;
		transform.localPosition = newLocation; 
		StaticVars.nextSectionPos += StaticVars.distance;
		}

}