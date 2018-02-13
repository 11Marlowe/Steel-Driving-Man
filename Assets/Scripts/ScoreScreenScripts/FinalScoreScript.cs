using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreScript : MonoBehaviour
{
    private int finalScore;
    public Text scoreText;

	// Use this for initialization
	void Start ()
    {
        // set the final score to be whatever the score was whent he player lost the game
        finalScore = ScoreController.score;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // update the score on screen
        scoreText.text = "       " + finalScore; 
	}
}
