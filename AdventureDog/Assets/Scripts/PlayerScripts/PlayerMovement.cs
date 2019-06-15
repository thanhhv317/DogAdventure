using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 3f;
    public float jumpHight = 5f;

    public static PlayerMovement player;
    public bool facingRight;

    bool grounded;
    public Transform tele;

    public Transform pos;
    public GameObject stone;
    private float timeR=0;
    public float cooldown = 2f;

    public Rigidbody2D myBody;
    private Animator anim;

    private void Awake()
    {
        if (player == null)
        {
            player = this;
        }
        else Destroy(gameObject);
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {
        facingRight = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("run", Mathf.Abs(move));
        myBody.velocity = new Vector2(move * speed, myBody.velocity.y);
        if (move > 0 && !facingRight)
        {
            flip();
        }
        else if (move < 0 && facingRight)
        {
            flip();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            jump();
        }
        if (Input.GetKey(KeyCode.Q))
        {
            if (Time.time > timeR)
            {
                anim.SetTrigger("attack");
                timeR = Time.time + cooldown;
                StartCoroutine(delay(0.3f));
            }
        }
        

    }

    void flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Ground"  || target.gameObject.tag=="Bullet_Player")
        {
            grounded = true;
            anim.SetBool("jump", false);
        }
    }
    void jump()
    {
        anim.SetBool("jump", true);
        if (grounded)
        {
            grounded = false;
            myBody.velocity = new Vector2(myBody.velocity.x, jumpHight);
        }
    }

    void attack()
    {
        if(Items.item.hasAStone)
            Instantiate(stone, pos.position, Quaternion.identity);
    }

    IEnumerator delay(float time)
    {
        yield return new WaitForSeconds(time);
        attack();
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Tele")
        {
            transform.position = tele.position;
        }
    }
}

