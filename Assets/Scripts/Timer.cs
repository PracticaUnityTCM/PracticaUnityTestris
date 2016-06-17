using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    
 
    public string TimerText="";
    public float Minutes;
    public float Seconds;
    private float _Minutes;
    private float _Seconds;
    private GameHud _gameHud;
   
    void Start()
    {
        
    }
    public void StartTimer()
    {

        _Minutes = Minutes;
        _Seconds = Seconds;
        StartCoroutine(Wait());
         
    }
    void Update()
    {
        if (Seconds < 10)
        {
            TimerText = (Minutes + ":0" + Seconds);
        }
        if (Seconds > 9)
        {
            TimerText = (Minutes + ":" + Seconds);
        }
      


    }
    public void CountDown()
    {
        if (Seconds <= 0)
        {
            MinusMinute();
            Seconds = 60;
        }
        if (Minutes >= 0)
        {
            MinusSeconds();
        }
        if (Minutes <= 0 && Seconds <= 0)
        {
           
            StopTimer();
            StartTimer();
            
        }
        else
        {
            StartTimer();
        }

    }
    public void MinusMinute()
    {
        if(GameManager.Instance.IsHardDificulty)
        GameManager.Instance.SpeedPices -= 0.25f;
        Minutes -= 1;
    }
    public void MinusSeconds()
    {
      
        Seconds -= 1;
        // a mi n o m'acaba d'agradar aquest sistema de gird xq tu mos 1 unitat cadavegada i el temps es 0.001 o m'entens
        // tu b vls moddificar la  velocitat en funcio d'un temps 
        // x podero fer has de fer q les peces es mogui amb posicions 1,2 ,3
        // la veocitat ve  1 a 0 
        
             
    }
    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        CountDown();
      
    }
    public void StopTimer()
    {
        _Seconds = 0;
        _Minutes = 0;
      //  var _Camera =(GameObject) GameObject.Find("Main Camera");
  //     _gameHud= _Camera.GetComponent<GameHud>();
     //   _gameHud.stateStartScene = GameHud.StateStartScene.End;
        
    }
    public void ResetTimer()
    {
         Seconds= _Seconds;
         Minutes= _Minutes;
    }
}
    