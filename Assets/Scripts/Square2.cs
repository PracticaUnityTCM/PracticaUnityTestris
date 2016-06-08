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
            new Vector3(transform.position.x + 1f*4, transform.position.y+0.5f, 0),
            new Vector3(transform.position.x - 1f * 4, transform.position.y+.5f, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 1f * 4, transform.position.y +0.5f*3 , 0),
            new Vector3(transform.position.x + (-1f) * 4, transform.position.y+0.5f*3, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 1f * 4, transform.position.y - 0.5f * 3, 0),
            new Vector3(transform.position.x - 1f * 4, transform.position.y - 0.5f * 3, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 1f * 4, transform.position.y + 0.5f * 5, 0),
            new Vector3(transform.position.x - 1f * 4, transform.position.y + 0.5f * 5, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 1f * 4, transform.position.y - 0.5f * 5, 0),
            new Vector3(transform.position.x - 1f * 4, transform.position.y - 0.5f * 5, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 1f * 4, transform.position.y - 0.5f , 0),
            new Vector3(transform.position.x - 1f * 4, transform.position.y - 0.5f , 0)
            );
        //vertical
        Gizmos.DrawLine(
            new Vector3(transform.position.x+0.5f, transform.position.y - 1f *4, 0),
            new Vector3(transform.position.x+0.5f, transform.position.y + 1f* 4, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x - 0.5f, transform.position.y - 1f * 4, 0),
            new Vector3(transform.position.x - 0.5f , transform.position.y + 1f * 4, 0)
            );
        Gizmos.DrawLine(
            new Vector3(transform.position.x - 0.5f * 3, transform.position.y - 1f * 4, 0),
            new Vector3(transform.position.x - 0.5f * 3, transform.position.y + 1f * 4, 0));
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.5f * 3, transform.position.y - 1f * 4, 0),
            new Vector3(transform.position.x + 0.51f * 3, transform.position.y +1f * 4, 0));
        Gizmos.DrawLine(
            new Vector3(transform.position.x + 0.5f * 5, transform.position.y - 1f * 4, 0),
            new Vector3(transform.position.x + 0.5f * 5, transform.position.y + 1f * 4, 0));
        Gizmos.DrawLine(
            new Vector3(transform.position.x - 0.5f * 5, transform.position.y - 1f * 4, 0),
            new Vector3(transform.position.x - 0.5f * 5, transform.position.y + 1f * 4, 0));
    }
}
