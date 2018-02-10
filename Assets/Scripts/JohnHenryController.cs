using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnHenryController : MonoBehaviour
{
    private Transform player;
    private GameObject[] railwaySpike;
    public ScoreController score;
    public float floorSpikeHitbox;
    public float ceilingSpikeHitbox;
    private bool spikeInPosition;

	// Use this for initialization
	void Start ()
    {
        player = GetComponent<Transform>();
        railwaySpike = GameObject.FindGameObjectsWithTag("spike");
        spikeInPosition = false;
	}
	
	// Update is called once per frame
	void Update ()
    {   
        if (spikeInPosition && Input.GetKeyDown(KeyCode.Space))
        {
            score.increaseScore();
        }
	}

    private void OnCollisionStay2D(Collision collision)
    {
        foreach(GameObject spike in railwaySpike)
        {
            if (collision.collider == spike.GetComponent<BoxCollider2D>())
            {
                spikeInPosition = true;
            }
        }
        
    }
}
