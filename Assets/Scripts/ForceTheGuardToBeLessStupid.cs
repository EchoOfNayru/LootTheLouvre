using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTheGuardToBeLessStupid : MonoBehaviour {

    public GameObject TheEntireProblem;
    guardPathTest helpMe;

	// Use this for initialization
	void Start () {
        helpMe = TheEntireProblem.GetComponent<guardPathTest>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<guardPathTest>() != null)
        {
            helpMe.statueIndex++;
        }
    }
}
