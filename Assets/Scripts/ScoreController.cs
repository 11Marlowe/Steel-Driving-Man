using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    private Text scoreText;
    private int score;

	// Use this for initialization
	void Start ()
    {
        scoreText = GetComponent<Text>();
        score = 0;
	}

    public void increaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    public int getScore()
    {
        return score;
    }
}
