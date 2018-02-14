using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class guardPathTest : MonoBehaviour {

    public NavMeshAgent nav;
    public GameObject[] statues;
    public int statueIndex;
    bool artAlarm = false;

    //Zach
    public bool ChasingThief;
    public GameObject Thief;
    FieldOfView fov;

    //Randomizer
    public float moveSpeed;
    public float FoVRadius;
    public float FoVAngle;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        fov = GetComponent<FieldOfView>();
        statueIndex = 0;
        Vector3 destPos = statues[statueIndex].transform.position;
        destPos.y = transform.position.y;
        nav.destination = destPos;

        //Randomizer
        moveSpeed = Random.Range(3f, 10f);
        nav.speed = moveSpeed;
        FoVRadius = Random.Range(10f, 16f);
        fov.viewRadius = FoVRadius;
        FoVAngle = Random.Range(75f, 114f);
        fov.viewAngle = FoVAngle;

        //Zach
        ChasingThief = false;
    }
   // public GameObject thing;
    // Update is called once per frame
    void Update()
    {
        //Zach
        if (!ChasingThief)
        {
            nav.destination = statues[statueIndex].transform.position;
        }
        if (ChasingThief)
        {
            nav.destination = Thief.transform.position;
        }

        if (artAlarm == true)
        {
            nav.speed = 8f;
        }
    }


    //protected bool pathComplete()
    //{
    //    if (!nav.pathPending)
    //    {
    //        if (nav.stoppingDistance >= Vector3.Distance(transform.position, statues[statueIndex].transform.position))
    //        {
    //            if (!nav.hasPath || nav.velocity.sqrMagnitude == 0f)
    //            {
    //                return true;
    //            }
    //        }
    //    }
    //    return false;
    //}

}

// guard needs to go to the first art piece, then leave that art piece and cycle through continuously
// so that means each art piece needs a script that turns of its own bool and turns on the next
//

