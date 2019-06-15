using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour {

    Rigidbody2D rb;
    Animator anim;
    public float speedX, speedY;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            rb.velocity = new Vector2(speedX, speedY);
            anim.SetTrigger("attack");
        }
    }

}
