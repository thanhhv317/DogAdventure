using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elip : MonoBehaviour {
    Rigidbody2D mybody;
    public float minX=-2, maxX=4, minY=-2, maxY=3;

	// Use this for initialization
	void Start () {
        mybody = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y<maxY && transform.position.x < maxX)
        {
            mybody.gravityScale = -0.1f;
            mybody.velocity = new Vector2(2, mybody.velocity.y);
        }
        if(transform.position.y>maxX && transform.position.x > minY)
        {
            mybody.gravityScale = -0.1f;
            mybody.velocity = new Vector2(-2, mybody.velocity.y);
        }
        if(transform.position.y>minY && transform.position.x < minY)
        {
            mybody.gravityScale = 0.1f;
            mybody.velocity = new Vector2(-2, mybody.velocity.y);
        }
      
	}
}
