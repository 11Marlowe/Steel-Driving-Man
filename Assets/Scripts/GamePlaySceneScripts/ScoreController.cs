using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    // this variable represents the text that appears on the screen
    private Text scoreText;
    // this is the variable that keeps track of the score
    public static int score;

	// Use this for initialization
	void Start ()
    {
        scoreText = GetComponent<Text>();
        score = 0;
	}

    // increase the score and set the text on the screen to reflect
    public void increaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    // a getter for the score variable 
    public int getScore()
    {
        return score;
    }
}
