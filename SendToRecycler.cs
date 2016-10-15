using UnityEngine;
using System.Collections;
using System;

public class SendToRecycler : MonoBehaviour {

    public static Action<SendToRecycler> sendThis;
	
    	void Start () {
        sendThis(this);
	}
}
