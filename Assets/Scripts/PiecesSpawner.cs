using UnityEngine;
using System.Collections;

public class PiecesSpawner : MonoBehaviour {


    public GameObject[] _pieces = new GameObject[7];
//	public Color[] color = new Color[7];
    public GameObject aux,obj;
    public int i;

   
    void Start () 
	{

        if (!GameManager.Instance.IsHardDificulty)
        {
            CreateToView();
            Create();
        }
        else
            Create();
     
	}
	
	// Update is called once per frame
	
	public void Create()
	{
        
		var i = Random.Range (0, _pieces.Length);

        obj = (GameObject)Instantiate(_pieces[i], transform.position + new Vector3(12,4), Quaternion.identity);
        
		var ii = Random.Range (0, 6);
       

        obj.GetComponent<PieceMove>().StartMove();
       


    }
    public void CreateToView()
    {
        var i = Random.Range(0, _pieces.Length);
         aux = (GameObject)Instantiate(_pieces[i],transform.position + new Vector3(0, 0,3), Quaternion.identity);
       var ii = Random.Range(0, 6);
      
        aux.GetComponent<PieceMove>().isOnViewMode = true;
        

    }
   public void MoveToStartMoving()
    {
        aux.transform.position = transform.position + new Vector3(12, 4);
        aux.GetComponent<PieceMove>().StartMove();
    }
}
