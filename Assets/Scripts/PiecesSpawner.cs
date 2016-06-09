using UnityEngine;
using System.Collections;

public class PiecesSpawner : MonoBehaviour {


    public GameObject[] _pieces = new GameObject[7];
	public Color[] color = new Color[7];

    // aixo es la refercia al prefab es 1 
    // Use this for initialization
    void Start () 
	{
       
        Create();
     
	}
	
	// Update is called once per frame
	

	public void Create()
	{
		var i = Random.Range (0, _pieces.Length);
		GameObject obj = (GameObject)Instantiate (_pieces [i], transform.position, Quaternion.identity);
		i = Random.Range (0, color.Length);
		obj.GetComponent<SpriteRenderer> ().color = color [i];
		foreach (SpriteRenderer a in obj.GetComponentsInChildren<SpriteRenderer> ()) {
			a.material.color = obj.GetComponent<SpriteRenderer> ().color;

		}
	}
}
