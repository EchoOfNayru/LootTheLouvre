using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuardCatchThief : MonoBehaviour {

    public string SceneToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<pathTester>() != null)
        {
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}
