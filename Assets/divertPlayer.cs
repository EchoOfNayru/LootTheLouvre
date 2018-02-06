using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class divertPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<guardPathTest>();
        player.firstCollision = true;
        //need one object of a collision to have a rigidbody
    }
}
