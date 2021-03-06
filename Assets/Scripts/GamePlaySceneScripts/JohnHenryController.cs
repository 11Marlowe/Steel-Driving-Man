﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    // a boolean to control weather or not the player can hit a spike for points
    private bool canHammer;
    // health for the player
    private int health;
    // the script controlling the healthBar for the player
    public HealthBarController lifeBar;
    private bool spikeWasHit;
    private GameObject currentSpike;
    public Sprite spikeDownSprite;
    // the variables holding the hammer sound and the audio source that will control it
    public AudioSource audioSource;
    public AudioClip hammerSound;
    // the animation component on henry and the time to wait after the animation before setting the spike to be down
    public Animator anim;
    public float waitTime;

	// Use this for initialization
	void Start ()
    {
        player = GetComponent<Transform>();
        railwaySpike = GameObject.FindGameObjectsWithTag("spike");
        canHammer = false;
        health = 3;
        spikeWasHit = false;
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {   
        // check each railway spike to see if any of them are in the target area for the player to hit
        // if they are then make canHammer true and highlight the spike, otherwise make sure the spike is not highlighted
        foreach (GameObject spike in railwaySpike)
        {
            if (spike.GetComponent<Transform>().position.y < ceilingSpikeHitbox
                    && spike.GetComponent<Transform>().position.y > floorSpikeHitbox)
            {
                spike.GetComponent<RailWaySpikeController>().highlightSpike();
                canHammer = true;
                currentSpike = spike;
            }
            else
            {
                spike.GetComponent<RailWaySpikeController>().returnToNormal();
            }
        }

        // if the player hits the space bar and canHammer is true then increase the score,
        // play john henry's animation, otherwise decrease player health.
        if (Input.GetKeyDown(KeyCode.Space) && canHammer)
        {
            score.increaseScore();
            canHammer = false;
            anim.Play("JohnHenryAnimation");
            // coroutine to set the spike to hit
            StartCoroutine(waitForHammerAnim());
            audioSource.PlayOneShot(hammerSound);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && !canHammer)
        {
            health--;
            lifeBar.updateHealth(health);
            anim.Play("JohnHenryAnimation");
        }
        else
        {
            canHammer = false;
        }

        // if the players health is at 0 then the game is over, go to the score screen
        if(health == 0)
        {
            SceneManager.LoadScene("ScoreScreen");
        }
    }

    // this enumerator is used to make sure the spike going down is synced with henry's hammer hitting it
    private IEnumerator waitForHammerAnim()
    {
        yield return new WaitForSeconds(waitTime);
        currentSpike.GetComponent<RailWaySpikeController>().setWasHit(true);
    }
}
