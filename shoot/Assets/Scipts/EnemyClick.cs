using UnityEngine;
using System.Collections;

public class EnemyClick : MonoBehaviour {


    public float numberOfClicks = 1.0f;
    public float respawnWaitTime = 1.0f;
    public float spawnWaitTime = 5.0f;
    public Transform explosion;

    private Color32[] shapeColor = new Color32[2];

    public int enemyPoint;

    private float timeStamp = 0f; 

    private float storeClicks = 0f;
	// Use this for initialization
	void Start () {
        StartCoroutine(RespawnWaitTime());
        Vector2 position = new Vector2(Random.Range(-6.0f, 6.0f), Random.Range(-4.0f, 4.0f));
        transform.position = position;
        storeClicks = numberOfClicks;
        
        shapeColor[0] = new Color32(255, 121, 0, 255);
        shapeColor[1] = new Color32(0, 0, 255, 255);
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > timeStamp)
        {
            timeStamp = Time.time + spawnWaitTime;

            RandomPosition();
        }

        
        if (numberOfClicks <= 0)
        {
            if (explosion)
                Instantiate(explosion,transform.position,transform.rotation);
            RandomPosition();
            timeStamp = Time.time + spawnWaitTime;
        }
        
	}

    void RandomPosition()
    {

        Vector2 position = new Vector2(Random.Range(-6.0f, 6.0f), Random.Range(-4.0f, 4.0f));
        transform.position = position;
        StartCoroutine(RespawnWaitTime());
        numberOfClicks = storeClicks;
    }

    IEnumerator RespawnWaitTime()
    {
        renderer.enabled = false;
        yield return new WaitForSeconds(respawnWaitTime);
        RandomColor();
        renderer.enabled = true;
    }


    void RandomColor()
    {
        int newColor = Random.Range(0, shapeColor.Length);
        SpriteRenderer render = GetComponent<SpriteRenderer>();
        render.color = shapeColor[newColor];

        if (newColor == 1)
            enemyPoint = -1;
        else
            enemyPoint = 1;
    }
}
