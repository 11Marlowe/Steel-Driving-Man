using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnHenryController : MonoBehaviour
{
    private Transform player;
    // an array that holds all of the railway spikes
    private GameObject[] railwaySpike;
    // an instance of the scoreController script so that we can call the method increase score
    public ScoreController score;
    // the variables that define the area the spikes must be in for the player to hit them
    public float floorSpikeHitbox;
    public float ceilingSpikeHitbox;

	// Use this for initialization
	void Start ()
    {
        player = GetComponent<Transform>();
        railwaySpike = GameObject.FindGameObjectsWithTag("spike");
	}
	
	// Update is called once per frame
	void Update ()
    {   
        // if the space key is pressed then check all of the railway spikes, 
        // if any of the railway spikes are in the target area then increase the score
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach(GameObject spike in railwaySpike)
            {
                if(spike.GetComponent<Transform>().position.y < ceilingSpikeHitbox
                    && spike.GetComponent<Transform>().position.y > floorSpikeHitbox)
                {
                    score.increaseScore();
                }
            }
        }
	}
}
