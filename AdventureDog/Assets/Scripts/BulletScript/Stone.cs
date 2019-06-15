using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    public float speed = 2f;
    Rigidbody2D myBody;
    public GameObject ef1;
    public static float damage = 10f;

    // Use this for initialization
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        fire(PlayerMovement.player.facingRight);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void fire(bool right)
    {
        if (right == true)
        {
            myBody.velocity = new Vector2(speed * 1, myBody.velocity.y + 4f);
        }
        else
        {
            myBody.velocity = new Vector2(speed * -1, myBody.velocity.y + 4f);
        }
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag=="Enemy" || target.gameObject.tag == "Ground")
        {
            Instantiate(ef1, transform.position, Quaternion.identity);
        }
    }
}