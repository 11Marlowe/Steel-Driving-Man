using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineScript : MonoBehaviour
{
    private bool machineHit;
    private GameObject[] railwaySpikes;
    public JohnHenryController jh;

    // Use this for initialization
    void Start ()
    {
        machineHit = false;
        railwaySpikes = GameObject.FindGameObjectsWithTag("machineSpike");
    }
	
	// Update is called once per frame
	void Update ()
    {
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
