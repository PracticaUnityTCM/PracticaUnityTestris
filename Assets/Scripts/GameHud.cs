using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHud : MonoBehaviour {
    public GUISkin skin;
    public GUISkin skinGame;
    private GameObject cam;
    private Timer _timer;
    public GameObject texttimerobj;
    public Text textTime;
    public GameObject textScoreObj;
    public Text textScore;
	// Use this for initialization
	void Start () {
      
        
        
	}
	
	// Update is called once per frame
	void Update () {
        cam = GameObject.Find("Main Camera");
        _timer = cam.GetComponent<Timer>();
        texttimerobj = (GameObject)GameObject.Find("TimeText");
        textTime = texttimerobj.GetComponent<Text>();
           textTime.text =_timer.TimerText;
        textScoreObj = (GameObject)GameObject.Find("ScoreText");
        textScore = textScoreObj.GetComponent<Text>();
        textScore.text = GameManager.Instance.Points.ToString();
        if (GameManager.Instance.currentState == Menu.State.End)
        {
            SceneManager.LoadScene("Menu");
        }
        
        
    }
    void OnLevelWasLoaded(int level)
    {
        if (level == 1)

            _timer = (Timer)GameObject.FindObjectOfType<Timer>();
        _timer.StartTimer();

    }

}
