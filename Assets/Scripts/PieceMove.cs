using UnityEngine;
using System.Collections;

public class PieceMove : MonoBehaviour
{
    public float Speed = 0.5f;
    float lastFall;
    public Vector3 Velocity = new Vector3(0, -1, 0);
    // lo q vam prova illuns a classe
    // Modify position
    //transform.position += new Vector3(0, -1, 0);
    public float TimeStop = 1f;

    // cada quant fa salt
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Speed = 1.1f;
        Debug.Log("ss" + Speed);
        transform.Translate(new Vector3(0, Velocity.y, 0));
        // InvokeRepeating("StopPiece",0,TimeStop);

    }
    // esta baixar amb moviment interrumput
    private void StopPiece()
    {
        Speed = 0;

        Debug.Log("ss" + Speed);
        //       transform.position=new Vector3(0, 0 ,0);
        //yield return new WaitForSeconds (1f);
        
    }
    // aui a arribat a baix la peca
    //public void StopPieceIsDown()
    //{
    //    if (transform.position.y < Screen.height/4){
    //        transform.Translate(new Vector3(transform.position.x, 0,0));
    //    }
    //    CancelInvoke("StopPiece");
    //}
    // aixo fa 

    
}
// la posicio del fill en el grid no es null   