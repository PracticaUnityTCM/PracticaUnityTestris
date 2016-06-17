using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameHud : MonoBehaviour {
    public GUISkin skin;
    public GUISkin skinGame;
    private GameObject cam;
    private Timer timer;
    public GameObject texttimerobj;
    public Text textTime;
    public GameObject textScoreObj;
    public Text textScore;
	// Use this for initialization
	void Start () {
        cam = GameObject.Find("Main Camera");
        timer = cam.GetComponent<Timer>();
        
        
	}
	
	// Update is called once per frame
	void Update () {
        cam = GameObject.Find("Main Camera");
        timer = cam.GetComponent<Timer>();
        texttimerobj = (GameObject)GameObject.Find("TimeText");
        textTime = texttimerobj.GetComponent<Text>();
           textTime.text =timer.TimerText;
        textScoreObj = (GameObject)GameObject.Find("ScoreText");
        textScore = textScoreObj.GetComponent<Text>();
        textScore.text = GameManager.Instance.Points.ToString();

        
        
    }
    
}
