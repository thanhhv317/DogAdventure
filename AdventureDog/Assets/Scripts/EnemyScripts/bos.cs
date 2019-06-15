using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bos : MonoBehaviour {

    public GameObject ball;
    float cooldown;
    private float timeRate = 1f;
	// Use this for initialization
	void Start () {
		cooldown = Random.Range(2, 4);
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > timeRate && tele.tmp.check)
        {
            timeRate += cooldown;
            Instantiate(ball, transform.position, Quaternion.identity);
        }
	}
}
