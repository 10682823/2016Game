using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevel : MonoBehaviour
{
    private Vector3 movePos;

    private List<SendToRecycler> recycleList;
    void SendThisHandler(SendToRecycler _r)
    {
        recycleList.Add(_r);
        print(recycleList.Count);
    }

    // Use this for initialization
    void Start()
    {
        recycleList = new List<SendToRecycler>();
        SendToRecycler.sendThis += SendThisHandler;


    }

    void OnTriggerEnter()
    {
        movePos.x = Statics.nextPosition;
        recycleList[0].transform.position = movePos;
        Statics.nextPosition += Statics.distance;
    }

    // Update is called once per frame
    void Update()
    {

    }
}