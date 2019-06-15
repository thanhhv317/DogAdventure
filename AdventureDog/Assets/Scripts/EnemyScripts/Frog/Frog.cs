using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour {

    Rigidbody2D myBody;
    Animator anim;
    public static float speed=1f;
    public static bool facingRight = true;

    private float idle;
    private float walk;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        myBody = GetComponent<Rigidbody2D>();

        idle = Random.Range(3, 8);
	}
	
	// Update is called once per frame
	void Update () {
        myBody.velocity = new Vector2(facing()*speed, myBody.velocity.y);
        anim.SetFloat("speed", speed);

        GetComponent<SpriteRenderer>().flipX = facingRight;
        Transform();

    }

    float facing()
    {
        return facingRight ? -1 : 1; // on the right is right, on the left is wrong
    }

    void Transform()
    {
        if (idle > 0)
        {
            idle -= Time.deltaTime;

            if (idle < 0)
            {
                walk = Random.Range(4, 10);
                speed = Random.Range(1, 4);
            }
        }
        if (walk > 0)
        {
            walk -= Time.deltaTime;

            if (walk < 0)
            {
                idle = Random.Range(3, 8);
                speed = 0;
            }
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


    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            anim.SetTrigger("attack");
        }
    }

}
