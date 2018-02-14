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
    public GameObject artLocation5;
    public GameObject artPiece5;
    public GameObject exit;

    public float firstCollision;
    public float storedValue;

    public bool backTracking;
    private int backtrackTimer;

    //randomizers
    public float moveSpeed;
    public float FoVRadius;
    public float FoVAngle;

	void Start () {
        nav = GetComponent<NavMeshAgent>();
        firstCollision = 0;
        fov = GetComponent<FieldOfView>();
        backtrackTimer = 0;
        backTracking = false;

        //randomizers
        moveSpeed = Random.Range(4f, 12f);
        nav.speed = moveSpeed;
        FoVRadius = Random.Range(12f, 20f);
        fov.viewRadius = FoVRadius;
        FoVAngle = Random.Range(80f, 135f);
        fov.viewAngle = FoVAngle;
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
            nav.destination = artLocation5.transform.position;
            artPiece4.SetActive(false);
        }
        else if (firstCollision == 5)
        {
            nav.destination = exit.transform.position;
            artPiece5.SetActive(false);
        }
        else if (firstCollision == 6)
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
