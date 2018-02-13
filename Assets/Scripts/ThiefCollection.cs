using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefCollection: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var player = other.GetComponent<pathTester>();
            player.firstCollision++;
            Debug.Log(player.firstCollision);
        }
    }
}
