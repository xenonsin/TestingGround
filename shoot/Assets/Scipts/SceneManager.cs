using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

    public float gameTime = 20f;
    static int score = 0;
    static int scoreToWin = 1;

    public GUIStyle style;

	// Use this for initialization
	void Start () {

        InvokeRepeating("CountDown", 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {

        if (gameTime <= 0)
        {
            if (score >= scoreToWin)
            {
                Application.LoadLevel("Win");
                PlayerPrefs.SetInt("SCORE", score);
                score = 0;
            }
            else
            {
                Application.LoadLevel("Lose");
                PlayerPrefs.SetInt("SCORE", score);
                score = 0;
            }

        }

	}

    public void AddScore(int points)
    {
        score += points;
    }

    void CountDown()
    {
        if (--gameTime == 0)
            CancelInvoke("CountDown");
    }


    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width - 100, 10, 100, 20), "Karma: " + score, style);
        GUI.Label(new Rect(280, 10, 100, 20), "Time: " +gameTime, style);
    }
}
