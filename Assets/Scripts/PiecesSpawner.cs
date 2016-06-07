using UnityEngine;
using System.Collections;

public class PiecesSpawner : MonoBehaviour {
	private bool bottom;
    [SerializeField]
    GameObject _pieceSquare;
    [SerializeField] GameObject _piece;

    // aixo es la refercia al prefab es 1 
	// Use this for initialization
	void Start () 
	{
		bottom = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
        //bottom = false;
        Create(ref bottom);


       
        Debug.Log(bottom);    
	}

	public void Create(ref bool  bottom)
	{
        // si tu 
		if (bottom) 
		{
			GameObject obj= (GameObject)Instantiate (_piece, transform.position, transform.rotation);
            obj.GetComponent<PieceMove>().StopPieceIsDown();
            
            Debug.Log(bottom);
        }
        bottom = false;
    }
}
