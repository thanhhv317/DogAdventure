using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour {

    public static Dragon dragon;
    public float speed;

    public Transform pos;
    public GameObject fire;

    Rigidbody2D mybody;
    Animator anim;
    public bool facingRight;
    bool isAttack;

    private float timeRate = 0f;
    private float cooldown = 1f;

    private void Awake()
    {
        if (dragon == null)
        {
            dragon = this;
        }
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start () {
        facingRight = false;
        isAttack = false;
    }
	
	// Update is called once per frame
	void Update () {
        move();
    }
    void move()
    {
        if (!isAttack)
        {
            mybody.velocity = new Vector2(speed, mybody.velocity.y);
            if (facingRight)
            {
                flip();
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
            anim.SetBool("attack",true);
            attack();
            isAttack = true;
            mybody.velocity = Vector2.zero;
        }
    }

    private void OnTriggerStay2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            if (cooldown > Time.time)
            {
                anim.SetBool("attack", true);
                attack();
                isAttack = true;
                mybody.velocity = Vector2.zero;
                cooldown = Time.time + timeRate;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            anim.SetBool("attack", false);
            move();
        }
        isAttack = false;
    }
    void attack()
    {
        Instantiate(fire, pos.position, Quaternion.identity);
    }

}
