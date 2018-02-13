using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBarScript : MonoBehaviour
{
    // the gameobject which this script component is attached to
    public GameObject spacebar;
    // how long to wait before destroying this gameobject
    public float waitTime;

	// Use this for initialization
	void Start ()
    {
   
	}

    // play the sparbar animation and then delete it
    private IEnumerator KillOnAnimationEnd()
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(spacebar);
    }

    void Update()
    {
        StartCoroutine(KillOnAnimationEnd());
    }
}
