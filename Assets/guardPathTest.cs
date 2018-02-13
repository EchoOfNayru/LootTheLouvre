using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class guardPathTest : MonoBehaviour {

    NavMeshAgent nav;
    //public GameObject artPiece;
    //public GameObject artPiece2;
    //public GameObject artPiece3;
    //public GameObject artPiece4;
    //public bool firstCollision;
    //public bool secondCollision;
    //public bool thirdCollision;
    //public bool fourthCollision;
    //public bool[] artPieces;
    public GameObject[] statues;
    public int statueIndex;
    bool artAlarm = false;
    void Start()
    {
        //artPieces = new bool[4];
        nav = GetComponent<NavMeshAgent>();
        //firstCollision = false;
        //secondCollision = true;
        //thirdCollision = true;
        //fourthCollision = true;
        //artPieces[0] = firstCollision;
        //artPieces[1] = secondCollision;
        //artPieces[2] = thirdCollision;
        //artPieces[3] = fourthCollision;

        //statues[0] = artPiece;
        //statues[1] = artPiece2;
        //statues[2] = artPiece3;
        //statues[3] = artPiece4;

        statueIndex = 0;
        nav.destination = statues[statueIndex].transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //set an if statement here, related to robber
        nav.SetAreaCost(0, 10);
        Debug.Log(nav.GetAreaCost(0));
        Debug.DrawLine(transform.position, nav.destination, Color.green);
        if(pathComplete())
        {
            if(statues[statueIndex].activeSelf == false)
            {
                artAlarm = true;
            }
            statueIndex++;
            if (statueIndex > statues.Length - 1)
            {
                statueIndex = 0;
            }
            nav.destination = statues[statueIndex].transform.position;
        }
        //thief alarm, if they spot thief all guards go to thief
        // if art is gone then they will move 3x speed
        

        //if (firstCollision == false)
        //{
        //    nav.destination = artPiece.transform.position;
        // //   nav.SetAreaCost(3, nav.GetAreaCost(3) + 1);
        //    //Debug.Log(nav.GetAreaCost(3));
        //}
        //else if (secondCollision == false)
        //{
        //    nav.destination = artPiece2.transform.position;
        //}
        //else if (thirdCollision == false)
        //{
        //    nav.destination = artPiece3.transform.position;
        //}
        //else if (fourthCollision == false)
        //{
        //    nav.destination = artPiece4.transform.position;
        //}
        if(artAlarm == true)
        {
            nav.speed = 8f;
        }
    }


    protected bool pathComplete()
    {
        if (!nav.pathPending)
        {
            if (nav.stoppingDistance >= nav.remainingDistance)
            {
                if (!nav.hasPath || nav.velocity.sqrMagnitude == 0f)
                {
                    return true;
                }
            }
        }
        return false;
    }

}

// guard needs to go to the first art piece, then leave that art piece and cycle through continuously
// so that means each art piece needs a script that turns of its own bool and turns on the next
//

