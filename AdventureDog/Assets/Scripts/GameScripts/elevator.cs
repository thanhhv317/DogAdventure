using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour {

    public float speed=0.3f;

    Rigidbody2D myBody;

	// Use this for initialization
	void Start () {
        myBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            {
                myBody.velocity = new Vector2(myBody.velocity.x, speed);
            }
        }
    }

    private void OnCollisionExit2D(Collision2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            {
                myBody.velocity = new Vector2(myBody.velocity.x, -speed*2);
            }
        }
    }

}
