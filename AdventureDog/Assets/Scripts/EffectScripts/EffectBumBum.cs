using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBumBum : MonoBehaviour {

    public float time=0.3f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
