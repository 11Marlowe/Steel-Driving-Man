using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBarScript : MonoBehaviour
{
    public GameObject spacebar;
    public float waitTime;

	// Use this for initialization
	void Start ()
    {
   
	}

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
