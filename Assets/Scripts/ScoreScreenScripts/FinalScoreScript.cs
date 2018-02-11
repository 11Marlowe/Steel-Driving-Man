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
        finalScore = ScoreController.score;
	}
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = "       " + finalScore; 
	}
}
