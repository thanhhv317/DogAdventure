using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kim : MonoBehaviour {
    public float speed = 1f;
    Rigidbody2D rbBullet;

	// Use this for initialization
	void Start () {
        rbBullet = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rbBullet.velocity = new Vector2(speed, rbBullet.velocity.y);
	}
}
