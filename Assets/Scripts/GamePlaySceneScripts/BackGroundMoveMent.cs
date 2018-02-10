using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMoveMent : MonoBehaviour
{
    private Transform background;
    // this array holds all of the railway spike objects
    private GameObject[] railwaySpikes;
    // instance of the score controller script so we can get the current score
    public ScoreController scoreScript;
    private int score;
    // holds the vector3 for the backgrounds constant movement
    private Vector3 backgroundMovement;
    // this vector3 will set the background back to it's start position
    private Vector3 backToStart;
    // how fast the background will move
    public float speed;
    public float setBackAmt;
    // how much the background's speed increases when the score increases
    public float speedIncrease;
    public Sprite normSpike;

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
        // if the score has risen then increase the speed of the background's movement
        if(score < scoreScript.getScore())
        {
            speed += speedIncrease;
            score = scoreScript.getScore();
        }

        // move the background at constant speed
        background.position += backgroundMovement * speed;
		
        // if the background has made its way out of the screen set it back to the beginning
        if(background.position.y > 2.15f)
        {
            foreach(GameObject spike in railwaySpikes)
            {
                spike.GetComponent<SpriteRenderer>().sprite = normSpike;
                spike.GetComponent<RailWaySpikeController>().setWasHit(false);
            }
            background.Translate(backToStart);
        }
    }
}
