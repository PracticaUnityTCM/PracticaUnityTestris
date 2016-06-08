using UnityEngine;
using System.Collections;

public class GameHud : MonoBehaviour {
    public GUISkin skin;
    private Timer _timer;
	// Use this for initialization
	void Start () {
                
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        GUI.skin = skin;
       // skin.customStyles.SetValue()

        GUILayout.BeginArea(new Rect(Screen.width/3,0,Screen.width/3, Screen.height/8    ));
        {
            GUILayout.BeginHorizontal();
            GUILayout.Space(5f);

            GUILayout.Box("Tetis", skin.GetStyle("titleStyle"));
            GUILayout.Space(50f);
            GUILayout.EndHorizontal();
        }
        GUILayout.EndArea();
        GUILayout.BeginArea(new Rect(0,Screen.height/7,Screen.width,Screen.height/2));
        {
            GUILayout.BeginHorizontal();
            {
                GUILayout.BeginArea(new Rect(0,0,Screen.width/2,Screen.height ));
                {
                    GUILayout.Box("Hola");
                }
                GUILayout.EndArea();
            }
            GUILayout.EndHorizontal();
        }
        GUILayout.EndArea();
        GUILayout.BeginArea(new Rect(Screen.width/2, Screen.height / 7, Screen.width, Screen.height));
        {
            GUILayout.BeginHorizontal();
            {
                GUILayout.BeginArea(new Rect(0, 0, Screen.width / 2, Screen.height));
                {
                    GUILayout.Box("Hola");
                }
                GUILayout.EndArea();
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(50f);
            GUILayout.BeginVertical();
            {
                GUILayout.Box("Hola");
            }
            GUILayout.EndVertical();
        }
        GUILayout.EndArea();
        GUI.Box(new Rect(0, 0, 3477, 89),"ff");
        {
            GUI.Label(new Rect(0, 0, 56, 78), "jj");    
        }

    }
    void OnLevelWasLoaded(int level)
    {
        if (level == 1)

            _timer = (Timer)GameObject.FindObjectOfType<Timer>();
        if (_timer != null)
            _timer.StartTimer();

    }
}
