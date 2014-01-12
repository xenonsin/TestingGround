using UnityEngine;
using System.Collections;

public class LevelOne : MonoBehaviour {

    public Transform vote;

    private float timeStamp;
    private float coolDown = 0.5f;



	// Use this for initialization
	void Start () {
        Debug.Log("Dimensions" + Screen.width / 2 + " , " + Screen.height / 2);
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > timeStamp)
        {
            timeStamp = Time.time + coolDown;
            Spawn();
        }
	
	}

    void Spawn()
    {
        Vector2 Coor = new Vector2(Random.Range(-6.0f, 6.0f), Random.Range(-4.0f, 4.0f));
        Instantiate(vote, Coor, Quaternion.identity);
    }
}
