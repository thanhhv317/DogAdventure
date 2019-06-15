using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBall : MonoBehaviour {
    Rigidbody2D myBody;
    public float speed=1f;
    bool facingRight;
    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        myBody = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
        facingRight = true;
	}
	
	// Update is called once per frame
	void Update () {
        move();
	}

    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            flip();
        }
        if (target.tag == "Player")
        {
            anim.SetBool("attack", false);
        }
    }
    void flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        speed *= -1;
    }

    void move()
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);

    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player" )
        {
            anim.SetBool("attack", true);
            if (facingRight && target.transform.position.x < transform.position.x)
            {
                flip();

            }
            else if (!facingRight && target.transform.position.x > transform.position.x)
            {
                flip();

            }
        }
    }

    private void OnTriggerStay2D(Collider2D target)
    {
        if (target.tag == "Player" )
        {           
            anim.SetBool("attack", true);
            if (facingRight && target.transform.position.x < transform.position.x)
            {
                flip();
            }
            else if (!facingRight && target.transform.position.x > transform.position.x)
            {
                flip();
            }
        }
    }

}
