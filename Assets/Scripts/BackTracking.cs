using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackTracking : MonoBehaviour {

    public GameObject player;
    pathTester pathing;
    //FieldOfView fov;

	// Use this for initialization
	void Start () {
        pathing = player.GetComponent<pathTester>();
        //fov = player.GetComponent<FieldOfView>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        pathTester CollisionCheck;
        CollisionCheck = other.GetComponent<pathTester>();
        if (CollisionCheck != null && pathing.backTracking)
        {
            pathing.backTracking = false;
            pathing.firstCollision = pathing.storedValue;
        }
    }
}
