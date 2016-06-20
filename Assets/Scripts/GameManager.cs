using UnityEngine;
class GameManager
{
    public static GameManager Instance {  get { return _instance ?? (_instance = new GameManager()); } }
    private static GameManager _instance;
    public bool IsHardDificulty;
    public int Points;
    public float SpeedPices=1f;
    public Timer timer;
    public bool IsStartView=true;
    public Menu.State currentState;
    public float posPeca;
    
    public  GameManager()
    {
        SpeedPices = 1;

    }
    public void AddPoints(int points)
    {
        Points += points;
    }
    public void Reset()
    {
        Points = 0;
    }
  

}


