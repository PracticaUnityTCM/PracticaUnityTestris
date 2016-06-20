using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class Menu : MonoBehaviour
{


    public float m_startButtonSize = 120f;
    public float m_exitButtonSize = 120f;
    public GUISkin skin;
    public enum State
    {
        Menu, Difficulty, Playing, End
    }
    private string
    textbtn1,
    textbtn2;


   




    // Use this for initialization
    void Start()
    {
        if (GameManager.Instance.IsStartView)
        {
            GameManager.Instance.currentState = State.Menu;
            textbtn1 = "START GAME";
            textbtn2 = "EXIT GAME";
            GameManager.Instance.IsStartView = false;
        }
    }
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.currentState == State.Difficulty)
        {
            textbtn2 = "HARD";
            textbtn1 = "EASY";
        }
    }

    void OnGUI()
    {
        GUI.skin = skin;
        GUI.color = Color.white;
       
        if (GameManager.Instance.currentState == State.Menu || GameManager.Instance.currentState == State.Difficulty )
        {
            if(GameManager.Instance.currentState==State.Difficulty)
            GUI.Label(new Rect(90,80, 200, 100), "Select Mode", skin.GetStyle("Label"));
            if (GameManager.Instance.currentState==State.Menu)
            {
                GUI.Label(new Rect(90, 80, 200, 100), "Tetris", skin.GetStyle("Label"));
                GUI.Label(new Rect(50, 300, 300, 100), "Autors : Sergi Regi, Enric Mestre, Raul Lopez", skin.GetStyle("Label"));
            }
            if (GUI.Button(new Rect(140, 150, m_startButtonSize, 50), textbtn1,skin.GetStyle("Button")))
            {

                if (GameManager.Instance.currentState == State.Difficulty)
                {
                    GameManager.Instance.IsHardDificulty = false;
                    SceneManager.LoadScene("Tetris");
                    GameManager.Instance.currentState = State.Playing;
                }
                else
                {
                    GameManager.Instance.currentState = State.Difficulty;
                }
            }

            if (GUI.Button(new Rect(140, 200, m_exitButtonSize, 50), textbtn2, skin.GetStyle("Button")))
            {
                if (GameManager.Instance.currentState == State.Difficulty)
                {
                    GameManager.Instance.IsHardDificulty = true;
                    GameManager.Instance.currentState = State.Playing;
                    SceneManager.LoadScene("Tetris");
                }
            }
            else
            {
                Application.Quit();
            }
        }
        else if (GameManager.Instance.currentState == State.End)
        {
            SceneManager.LoadScene("Menu");
            GUI.Label(new Rect(90, 80, 200, 50), string.Format("Final Score :{0}", GameManager.Instance.Points), skin.GetStyle("Label"));
            GUI.Label(new Rect(90, 150, 200, 100), "Game Over", skin.GetStyle("Label"));   
        }
        else if(GameManager.Instance.currentState == State.Playing)
        {
          
        }
    }
    void OnLevelWasLoaded(int level)
    {

        if (level == 1)
        {
            var cam = GameObject.Find("Main Camera");
            var timer = cam.GetComponent<Timer>();
            timer.StartTimer();
        }

    }
}