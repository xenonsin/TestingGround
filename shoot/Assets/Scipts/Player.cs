using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public string tagName;
    public GameObject SceneManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Use Mouse button to select GO.

        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log ("Button Works");
            //Raycast fro screen
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit)
            {
                if (hit.transform.tag == tagName)
                {
                    var enemyscript = hit.transform.GetComponent<EnemyClick>();
                    enemyscript.numberOfClicks -= 1;

                    SceneManager.transform.GetComponent<SceneManager>().AddScore(enemyscript.enemyPoint);
                }
            }
        }
	
	}


}
