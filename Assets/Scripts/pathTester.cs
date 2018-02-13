using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pathTester : MonoBehaviour {

    FieldOfView fov;
    NavMeshAgent nav;
    public GameObject artLocation;
    public GameObject artPiece;
    public GameObject artLocation2;
    public GameObject artPiece2;
    public GameObject artLocation3;
    public GameObject artPiece3;
    public GameObject artLocation4;
    public GameObject artPiece4;
    public GameObject exit;

    public float firstCollision;
    public float storedValue;

    public bool backTracking;

    private int backtrackTimer;
    private GameObject objectToDestroy;
    

	void Start () {
        nav = GetComponent<NavMeshAgent>();
        firstCollision = 0;
        fov = GetComponent<FieldOfView>();
        backtrackTimer = 0;
        backTracking = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (firstCollision == 0)
        {
            nav.destination = artLocation.transform.position;
        }
        else if (firstCollision == 1)
        {
            nav.destination = artLocation2.transform.position;
            artPiece.SetActive(false);
        }
        else if (firstCollision == 2)
        {
            nav.destination = artLocation3.transform.position;
            artPiece2.SetActive(false);
        }
        else if (firstCollision == 3)
        {
            nav.destination = artLocation4.transform.position;
            artPiece3.SetActive(false);
        }
        else if (firstCollision == 4)
        {
            nav.destination = exit.transform.position;
            artPiece4.SetActive(false);
        }
        else if (firstCollision == 5)
        {
            nav.destination = fov.point.transform.position;
        }

        if (backtrackTimer <= 0)
        {
            fov.point.transform.position = transform.position;
            backtrackTimer = 300;
        }

        if (!backTracking)
        {
            backtrackTimer--;
        }
    }
}
