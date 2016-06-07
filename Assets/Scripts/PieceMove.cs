using UnityEngine;
using System.Collections;

public class PieceMove : MonoBehaviour {
    public float Speed=5.1f;
    public float TimeStop = 5000f;
    public Vector2 Velocity;
    // cada quant fa salt
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector2(transform.position.x, -transform.position.y*Speed*Time.deltaTime));
        InvokeRepeating("StopPiece", 0, TimeStop);
	}
    // esta baixar amb moviment interrumput
    private void  StopPiece()
    {

        Debug.Log("ss");
            transform.Translate(new Vector2(transform.position.x, 0 * Speed * Time.deltaTime));
        
    }
    // aui a arribat a baix la peca
    public void StopPieceIsDown()
    {
        if (transform.position.y < Screen.height/4){
            transform.Translate(new Vector2(transform.position.x, 0));
        }
        CancelInvoke("StopPiece");
    }
    // aixo fa 
    
}
