using UnityEngine;
using System.Collections;

public class PiecesSpawner : MonoBehaviour {


    public GameObject[] _pieces = new GameObject[7];

    // aixo es la refercia al prefab es 1 
    // Use this for initialization
    void Start () 
	{
       
        Create();
     
	}
	
	// Update is called once per frame
	

	public void Create()
	{
        // si tu 
		
            var i = Random.Range(0, _pieces.Length);
			GameObject obj= (GameObject)Instantiate (_pieces[i], transform.position, Quaternion.identity);
          ///  obj.GetComponent<PieceMove>().StopPieceIsDown();
            

    }
}
