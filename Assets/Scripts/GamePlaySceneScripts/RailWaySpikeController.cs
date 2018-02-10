using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this class is not currently used
public class RailWaySpikeController : MonoBehaviour
{
    // the spriterenderer of the spike which will allow us to change its sprite
    private SpriteRenderer spikeSprite;
    public Sprite highlightedSpike;
    public Sprite nonHighlightedSpike;
    private bool wasHit;

	// Use this for initialization
	void Start ()
    {
        spikeSprite = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
          
	}

    // return the sprike to its non-highlighted state
    public void returnToNormal()
    {
        if(getWasHit())
        {
            return;
        }
        else
        {
            spikeSprite.sprite = nonHighlightedSpike;
        }
    }

    // highlight the spike when it is in the target area
    public void highlightSpike()
    {
        if(getWasHit())
        {
            return;
        }
        else
        {
            spikeSprite.sprite = highlightedSpike;
        }
        
    }

    public void setWasHit(bool hit)
    {
        wasHit = hit;
    }
    public bool getWasHit()
    {
        return wasHit;
    }
}
