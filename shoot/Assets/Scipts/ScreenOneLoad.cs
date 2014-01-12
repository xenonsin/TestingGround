using UnityEngine;
using System.Collections;

public class ScreenOneLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("Level One");
        }
        

	}

    void OnGUI()
    {
        GUI.BeginGroup(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 300, 200));

        GUI.Box(new Rect(0, 0, 200, 200), "Click All The Upvotes!");
        GUI.Label(new Rect(10, 30, 100, 200), "Click Anywhere to Continue.");

        
        

        GUI.EndGroup();

    }
}
