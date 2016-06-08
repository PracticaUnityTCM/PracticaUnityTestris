using UnityEngine;
class GameManager
{
    public static GameManager Instance {  get { return _instance ?? (_instance = new GameManager()); } }
    private static GameManager _instance;
    public  GameManager()
    {

    }

}


