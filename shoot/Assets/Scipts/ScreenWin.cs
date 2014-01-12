using UnityEngine;
using System.Collections;

public class ScreenWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.BeginGroup(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 300, 200));

        GUI.Box(new Rect(0,0, 200, 200), "You Win!");
        GUI.Label(new Rect(10, 30, 100, 30), "Karma: " + PlayerPrefs.GetInt("SCORE"));

        if (GUI.Button(new Rect(60, 60, 100, 50), "Next Level"))
        {
            Application.LoadLevel("Level Two");
        }

        if (GUI.Button(new Rect(60, 120, 100, 50), "Main Menu"))
        {
            Application.LoadLevel("Main Menu");
        }

        GUI.EndGroup();
        
    }
}
