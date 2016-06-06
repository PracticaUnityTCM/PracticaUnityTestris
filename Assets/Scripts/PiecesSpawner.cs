using UnityEngine;
using System.Collections;

public class PiecesSpawner : MonoBehaviour {
	private bool bottom;
	[SerializeField] GameObject _piece;

	// Use this for initialization
	void Start () 
	{
		bottom = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void Create(bool bottom)
	{
		if (bottom) 
		{
			Instantiate (_piece, transform.position, transform.rotation);
			bottom = false;
		}
	}
}
