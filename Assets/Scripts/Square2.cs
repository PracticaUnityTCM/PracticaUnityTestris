using UnityEngine;
using System.Collections;

public class Square2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnDrawGizmos()
    {
        //horizontal
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 6, transform.position.y-0.21f, 0),
            new Vector3(transform.position.x - 0.21f * 6, transform.position.y-0.21f, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 6, transform.position.y +0.21f , 0),
            new Vector3(transform.position.x + (-0.21f) * 6, transform.position.y+0.21f, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 6, transform.position.y - 0.21f * 3, 0),
            new Vector3(transform.position.x + (-0.21f) * 6, transform.position.y - 0.21f * 3, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 6, transform.position.y + 0.21f * 3, 0),
            new Vector3(transform.position.x - 0.21f * 6, transform.position.y + 0.21f * 3 , 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 6    , transform.position.y - 0.21f * 5, 0),
            new Vector3(transform.position.x - 0.21f * 6, transform.position.y - 0.21f * 5, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 6, transform.position.y + 0.21f * 5, 0),
            new Vector3(transform.position.x - 0.21f * 6, transform.position.y + 0.21f * 5, 0)
            );
        //vertical
        Gizmos.DrawLine(
            new Vector3(transform.position.x+0.21f, transform.position.y - 0.21f * 6, 0),
            new Vector3(transform.position.x+0.21f, transform.position.y + 0.21f * 6, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x - 0.21f , transform.position.y - 0.21f * 6, 0),
            new Vector3(transform.position.x - 0.21f , transform.position.y + 0.21f * 6, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x - 0.21f * 3, transform.position.y - 0.21f * 6, 0),
            new Vector3(transform.position.x - 0.21f * 3, transform.position.y + 0.21f * 6, 0));
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 3, transform.position.y - 0.21f * 6, 0),
            new Vector3(transform.position.x + 0.21f * 3, transform.position.y + 0.21f * 6, 0));
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.21f * 5, transform.position.y - 0.21f * 6, 0),
            new Vector3(transform.position.x + 0.21f * 5, transform.position.y + 0.21f * 6, 0));
        Gizmos.DrawLine(
            new Vector3(transform.position.x - 0.21f * 5, transform.position.y - 0.21f * 6, 0),
            new Vector3(transform.position.x - 0.21f * 5, transform.position.y + 0.21f * 6, 0));
    }
}
