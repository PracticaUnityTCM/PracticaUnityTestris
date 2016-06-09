using UnityEngine;
using System.Collections;

public class Square : MonoBehaviour {
    public GameObject cell;

	// Use this for initialization
	void Start () {
        //transform.Rotate(new Vector3(0,0,9),90f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnDrawGizmos()
    {
        //horizontal
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 4 , transform.position.y , 0),
            new Vector3(transform.position.x - 0.21f * 6 , transform.position.y , 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 4 , transform.position.y + 0.21f * 2 , 0),
            new Vector3(transform.position.x + (- 0.21f) * 6 , transform.position.y + 0.21f * 2 , 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 4, transform.position.y - 0.21f * 2, 0), 
            new Vector3(transform.position.x + (- 0.21f) * 6, transform.position.y - 0.21f * 2, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 4, transform.position.y +0.21f * 4, 0),
            new Vector3(transform.position.x - 0.21f * 6, transform.position.y + 0.21f * 4, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x+0.21f * 4, transform.position.y - 0.21f * 4, 0), 
            new Vector3(transform.position.x - 0.21f * 6, transform.position.y- 0.21f * 4, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x+0.21f * 4, transform.position.y+ 0.21f * 6, 0), 
            new Vector3(transform.position.x - 0.21f * 6, transform.position.y+ 0.21f *6 , 0)
            );
        //vertical
        Gizmos.DrawLine(
            new Vector3(transform.position.x, transform.position.y- 0.21f * 4, 0),
            new Vector3(transform.position.x, transform.position.y+0.21f * 6, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x - 0.21f * 2, transform.position.y - 0.21f * 4, 0), 
            new Vector3(transform.position.x - 0.21f * 2, transform.position.y + 0.21f * 6, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x - 0.21f * 4, transform.position.y - 0.21f * 4, 0), 
            new Vector3(transform.position.x - 0.21f * 4, transform.position.y   + 0.21f * 6, 0));
        Gizmos.DrawLine(
            new Vector3(transform.position.x+ 0.21f * 2, transform.position.y - 0.21f * 4, 0), 
            new Vector3(transform.position.x+0.21f * 2, transform.position.y + 0.21f * 6, 0));
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 4, transform.position.y - 0.21f * 4, 0),
            new Vector3(transform.position.x + 0.21f * 4, transform.position.y + 0.21f * 6, 0));
        Gizmos.DrawLine(
            new Vector3(transform.position.x - 0.21f * 6, transform.position.y- 0.21f * 4, 0), 
            new Vector3(transform.position.x - 0.21f *6, transform.position.y + 0.21f * 6, 0));
    }
}
