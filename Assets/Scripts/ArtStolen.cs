using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtStolen : MonoBehaviour {

    public GameObject ConnectedArtPiece;
    public bool ArtPieceStolen;

	void Start () {
        ConnectedArtPiece.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (ConnectedArtPiece.activeSelf == false)
        {
            ArtPieceStolen = true;
        }
	}
}
