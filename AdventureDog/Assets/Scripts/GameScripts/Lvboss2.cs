using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvboss2 : MonoBehaviour {

    public float speed = 1f;
    Rigidbody2D myBody;

    // Use this for initialization
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myBody.velocity = new Vector2(-speed, myBody.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "C")
        {
            stop();
            myBody.velocity = new Vector2(myBody.velocity.x, speed);
        }
        else if (target.tag == "D")
        {
            stop();
            myBody.velocity = new Vector2(-speed, myBody.velocity.y);
        }
        else if (target.tag == "A")
        {
            stop();
            myBody.velocity = new Vector2(myBody.velocity.x, -speed);
        }
        else if (target.tag == "B")
        {
            stop();
            myBody.velocity = new Vector2( speed, myBody.velocity.y);
        }
    }
    void stop()
    {
        myBody.velocity = Vector2.zero;
    }
}
