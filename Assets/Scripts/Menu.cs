using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class Menu : MonoBehaviour {


	public float m_startButtonSize=120f;
	public float m_exitButtonSize = 120f;
	// Use this for initialization

		


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnGUI()
	{
		GUI.color = Color.white;
		GUILayout.Label ("TETRIS");

		if (GUI.Button (new Rect (10, 20, m_startButtonSize, 50), "START GAME"))
		{
			SceneManager.LoadScene ("Tetris");
		}

		if (GUI.Button(new Rect(10,70,m_exitButtonSize,50),"EXIT GAME"))
		{
			Application.Quit ();	
		}

	}
}
