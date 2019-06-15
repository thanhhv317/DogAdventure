using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour {
    public float timeDestroy=1f;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, timeDestroy);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
