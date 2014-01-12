using UnityEngine;
using System.Collections;

public class ScreenMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.BeginGroup(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 300, 200));

        GUI.Box(new Rect(0, 0, 200, 200), "Hi.");

        if (GUI.Button(new Rect(60, 30, 100, 50), "Start Game"))
        {
            Debug.Log("Start GAME!");
            Application.LoadLevel("Level One Load");
        }
        if (GUI.Button(new Rect(60, 90, 100, 50), "Level Select"))
        {
 
            Application.LoadLevel("Level Select");
        }
        if (GUI.Button(new Rect(60, 150, 100, 50), "Quit Game"))
        {
            Debug.Log("QUIT!");
            Application.Quit();
        }

        GUI.EndGroup();
    }
}
