using UnityEngine;
using System.Collections;

public class PieceMove : MonoBehaviour {
        public float Speed=0.5f;
    float lastFall;
  
    // Modify position
    //transform.position += new Vector3(0, -1, 0);
      public float TimeStop = 1f;
      public Vector2 Velocity;
      // cada quant fa salt
      // Use this for initialization
      void Start () {

      }

      // Update is called once per frame
      void Update () {
        Speed = 1.1f;
        transform.position = new Vector3(transform.position.x, -transform.position.y*Speed*Time.deltaTime   , 0);
        InvokeRepeating("StopPiece",0,TimeStop);
        
      }
      // esta baixar amb moviment interrumput
      private void  StopPiece()
      {
        Speed = 0;

          Debug.Log("ss"+ spe);
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
