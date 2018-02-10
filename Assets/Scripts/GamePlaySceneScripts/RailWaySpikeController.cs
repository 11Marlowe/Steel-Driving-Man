using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this class is not currently used
public class RailWaySpikeController : MonoBehaviour
{
    private SpriteRenderer spikeSprite;
    public Sprite highlightedSpike;
    public Sprite nonHighlightedSpike;

	// Use this for initialization
	void Start ()
    {
        spikeSprite = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
          
	}

    public void returnToNormal()
    {
        spikeSprite.sprite = nonHighlightedSpike;
    }

    public void highlightSpike()
    {
        spikeSprite.sprite = highlightedSpike;
    }
}
