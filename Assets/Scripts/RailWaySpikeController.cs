using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailWaySpikeController : MonoBehaviour
{
    private float spikePosition;
    private bool canPlayerHammer;
    

	// Use this for initialization
	void Start ()
    {
        canPlayerHammer = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        
	}

    private void OnTriggerEnter(Collision2D collision)
    {
        canPlayerHammer = true;
    }

    public bool getCanPlayerHammer()
    {
        return canPlayerHammer;
    }
}
