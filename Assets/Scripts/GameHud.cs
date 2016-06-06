using UnityEngine;
using System.Collections;

public class GameHud : MonoBehaviour {
    public GUISkin skin;
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

        GUILayout.BeginArea(new Rect(0,0,Screen.width, Screen.height));
        {
            GUILayout.BeginArea(new Rect(0, 0, Screen.width /2, Screen.height), skin.GetStyle("Box"));
            {
                GUILayout.Box("Tetis");
                //GUILayout.BeginVertical();
                //{
                    GUILayout.BeginArea(new Rect(0,0 , Screen.width /2 , Screen.height+900 ), skin.GetStyle("Box2"));
                    {
                        //GUILayout.BeginVertical();
                        //{
                        //    GUILayout.BeginArea(new Rect(0, 0, Screen.width / 2, Screen.height));
                        //    {
                        //        //GUILayout.Button("Tetris", skin.GetStyle("Label"));
                        //    }
                        //    GUILayout.EndArea();
                        //}
                        //GUILayout.EndVertical();
                    }
                    GUILayout.EndArea();
                    //}
                    //GUILayout.EndVertical();
            }
            GUILayout.EndArea();
         
            GUILayout.BeginArea(new Rect(Screen.width / 2, 0, Screen.width , Screen.height));
            {
                GUILayout.BeginVertical(skin.GetStyle("Box"));
                {
                    GUILayout.BeginHorizontal();
                    {
                        GUILayout.Button("Tetris", skin.GetStyle("Label"));
                    }
                    GUILayout.EndVertical();
                }
                GUILayout.EndVertical();
            }
            GUILayout.EndArea();
        }
        GUILayout.EndArea();
            
    }
}
