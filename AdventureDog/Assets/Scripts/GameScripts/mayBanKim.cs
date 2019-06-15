using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mayBanKim : MonoBehaviour {

    public float coolDown = 1f;
    private float timeRate = 0f;
    public GameObject kim;
    public Transform pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > timeRate)
        {
            timeRate += coolDown;
            Instantiate(kim, pos.position, Quaternion.identity);
        }
	}
}
