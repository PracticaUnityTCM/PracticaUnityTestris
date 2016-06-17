using UnityEngine;
using System.Collections;

public class PiecesSpawner : MonoBehaviour {


    public GameObject[] _pieces = new GameObject[7];
//	public Color[] color = new Color[7];
    public GameObject aux,obj;
    public int i;

    // aixo es la refercia al prefab es 1 
    // Use this for initialization
    void Start () 
	{
     
      
        CreateToView();
        Create();
     
	}
	
	// Update is called once per frame
	
       // flag q digi si ha arriobat a vaig
	public void Create()
	{
        
		var i = Random.Range (0, _pieces.Length);

        obj = (GameObject)Instantiate(_pieces[i], transform.position + new Vector3(12,0), Quaternion.identity);
        
		var ii = Random.Range (0, 6);
        obj.GetComponent<PieceMove>().SetColor(ii);

        obj.GetComponent<PieceMove>().StartMove();
       


    }
    public void CreateToView()
    {
        Debug.Log("Cullons");
        var i = Random.Range(0, _pieces.Length);
         aux = (GameObject)Instantiate(_pieces[i],transform.position + new Vector3(0, 0,3), Quaternion.identity);
       // aux.tag = "notmove";
       var ii = Random.Range(0, 6);
        aux.GetComponent<PieceMove>().SetColor(ii);
        aux.GetComponent<PieceMove>().isOnViewMode = true;
        

    }
   public void MoveToStartMoving()
    {
        aux.transform.position = transform.position + new Vector3(12, 0);
        aux.GetComponent<PieceMove>().StartMove();
    }
}
