using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefCollection: MonoBehaviour {

    public bool ThiefHasStolen;

	// Use this for initialization
	void Start () {
        ThiefHasStolen = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && ThiefHasStolen == false)
        {
            var player = other.GetComponent<pathTester>();
            player.firstCollision++;
            Debug.Log(player.firstCollision);
            ThiefHasStolen = true;
        }
        //need one object of a collision to have a rigidbody
    }
}
