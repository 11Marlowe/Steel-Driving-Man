using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMoveMent : MonoBehaviour
{

    private Transform background;
    private GameObject[] railwaySpikes;
    public ScoreController scoreScript;
    private int score;
    private Vector3 backgroundMovement;
    private Vector3 backToStart;
    public float speed;
    public float setBackAmt;

	// Use this for initialization
	void Start ()
    {
        background = GetComponent<Transform>();
        backgroundMovement = new Vector3(0, 1.0f, 0);
        backToStart = new Vector3(0, setBackAmt, 0);
        railwaySpikes = GameObject.FindGameObjectsWithTag("spike");
        score = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(score < scoreScript.getScore())
        {
            speed += 0.0004f;
            score = scoreScript.getScore();
        }

        background.position += backgroundMovement * speed;
		
        if(background.position.y > 2.15f)
        {
            background.Translate(backToStart);
        }
    }
}
