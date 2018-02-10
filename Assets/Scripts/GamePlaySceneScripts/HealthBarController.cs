using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    public Sprite oneHealthLost;
    public Sprite twoHealthLost;
    public Sprite noHealth;
    private SpriteRenderer healthBarSprite;

	// Use this for initialization
	void Start ()
    {
        healthBarSprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void updateHealth(int health)
    {
        if(health == 2)
        {
            healthBarSprite.sprite = oneHealthLost;
        }
        else if(health == 1)
        {
            healthBarSprite.sprite = twoHealthLost;
        }
        else if(health == 0)
        {
            healthBarSprite.sprite = noHealth;
        }
    }
}
