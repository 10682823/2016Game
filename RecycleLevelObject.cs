using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevelObject : MonoBehaviour {
    
    private Vector3 newLocation;
    public List<Recycler> recyclableList;
    private int i = 0;

    void Start ()
    {
        recyclableList = new List<Recycler>();
        Recycler.RecycleAction += RecycleActionHandler;
    }

    private void RecycleActionHandler(Recycler _r)
    {
        recyclableList.Add(_r);
    }
    void OnTriggerEnter()
    {
		i = Random.Range (0, recyclableList.Count-1);
        newLocation.x = StaticVars.nextSectionPos;
		recyclableList[i].cube.position = newLocation;
		recyclableList.RemoveAt(i);
        StaticVars.nextSectionPos += StaticVars.distance;
        /*if (i < recyclableList.Count-1)
            i++;
            */
    }

}
