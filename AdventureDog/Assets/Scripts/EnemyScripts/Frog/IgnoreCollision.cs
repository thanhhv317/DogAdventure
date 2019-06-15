using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour {

    Collider2D player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player").GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), player, true);
	}
}
