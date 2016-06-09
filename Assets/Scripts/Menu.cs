using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class Menu : MonoBehaviour {


	public float m_startButtonSize=120f;
	public float m_exitButtonSize = 120f;
	private State currentState;
	private enum State
	{
		Menu, Difficulty , End
	}
	private  string 
	textbtn1,
	textbtn2;


	// Use this for initialization

		


	// Use this for initialization
	void Start ()
	{
		currentState = State.Menu;
		textbtn1 = "START GAME";
		textbtn2 = "EXIT GAME";
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (currentState == State.Difficulty) {
			textbtn2 = "HARD";
			textbtn1 = "EASY";
		}
	}

	void OnGUI()
	{
		GUI.color = Color.white;
		GUILayout.Label ("TETRIS");
			if (GUI.Button (new Rect (10, 20, m_startButtonSize, 50), textbtn1))
		{
			
			if (currentState == State.Difficulty) {
				SceneManager.LoadScene ("Tetris");
			} else {
				currentState = State.Difficulty;
			}
		}

		if (GUI.Button(new Rect(10,70,m_exitButtonSize,50),textbtn2))
		{
			Application.Quit ();	
		}

	}
}
