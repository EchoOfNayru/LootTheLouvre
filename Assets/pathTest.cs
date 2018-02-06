using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pathTest : MonoBehaviour {

    NavMeshAgent nav;
    public GameObject artPiece;
    public GameObject artPiece2;
    public bool firstCollision;

	void Start () {
        nav = GetComponent<NavMeshAgent>();
        firstCollision = false;
	}
	
	// Update is called once per frame
	void Update () {
		
        if(firstCollision == false)
        {
            nav.destination = artPiece.transform.position;
           // nav.SetAreaCost(3, nav.GetAreaCost(3) + 1);
           // Debug.Log(nav.GetAreaCost(3));
        }
        else if(firstCollision == true)
        {
            nav.destination = artPiece2.transform.position;
        }

	}
}
