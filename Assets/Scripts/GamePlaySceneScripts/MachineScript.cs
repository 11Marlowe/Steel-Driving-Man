using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineScript : MonoBehaviour
{ 
    // an array of all the railway machine spikes in the game 
    private GameObject[] railwaySpikes;
    // a reference to the script component on john henry
    public JohnHenryController jh;

    // Use this for initialization
    void Start ()
    {
        railwaySpikes = GameObject.FindGameObjectsWithTag("machineSpike");
    }
	
	// Update is called once per frame
	void Update ()
    {
        // if the machine spikes are under the machine then set them to be hit
		foreach(GameObject spike in railwaySpikes)
        {
            if(spike.GetComponent<Transform>().position.y < jh.ceilingSpikeHitbox
                    && spike.GetComponent<Transform>().position.y > jh.floorSpikeHitbox)
            {
                spike.GetComponent<RailWaySpikeController>().machineHit(true);
            }
        }
	}
}
