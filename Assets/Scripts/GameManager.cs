using UnityEngine;
class GameManager
{
    public static GameManager Instance {  get { return _instance ?? (_instance = new GameManager()); } }
    private static GameManager _instance;
    public bool IsHardDificulty;
    public int Points;
    public float SpeedPices=1f;
    public Timer timer;
    
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
    public void StartGame()
    {
        GameObject cam = (GameObject)GameObject.Find("Main Camera");
        Timer timer = cam.GetComponent<Timer>();
        timer.StartTimer();
    }

}


