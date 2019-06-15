using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForm : MonoBehaviour {
    public float speed = 1f;
    Rigidbody2D myBody;

	// Use this for initialization
	void Start () {
        myBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
	}

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Ground")
        {
            flip();
        }
    }

    void flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        speed *= -1;
        transform.localScale = theScale;
    }

}
