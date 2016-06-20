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
            //StartTimer();
            
        }
        else
        {
            StartTimer();
        }

    }
    public void MinusMinute()
    {
        if (GameManager.Instance.IsHardDificulty)
            GameManager.Instance.SpeedPices -= 0.25f;
        else
            GameManager.Instance.SpeedPices -= 0.225f;

        Minutes -= 1;
    }
    public void MinusSeconds()
    { 
        Seconds -= 1;
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
   
        GameManager.Instance.currentState = Menu.State.End;
    }
    public void ResetTimer()
    {
         Seconds= _Seconds;
         Minutes= _Minutes;
    }
}
    