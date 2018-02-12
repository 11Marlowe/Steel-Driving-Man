using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    public Sprite oneHealthLost;
    public Sprite twoHealthLost;
    public Sprite noHealth;
    // the spriterenderer of the healthbar which will allow us to change its sprite
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

    // change the healthbars sprite based on how much health the player has left
    public void updateHealth(int playerHealth)
    {
        if(playerHealth == 2)
        {
            healthBarSprite.sprite = oneHealthLost;
        }
        else if(playerHealth == 1)
        {
            healthBarSprite.sprite = twoHealthLost;
        }
        else if(playerHealth == 0)
        {
            healthBarSprite.sprite = noHealth;
        }
    }
}
