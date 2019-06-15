using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntantiateGround : MonoBehaviour {

    public Transform pos;
    public GameObject dieGr;
    Rigidbody2D myBody;
    Collider2D player;
    // Use this for initialization
    void Start () {
        myBody = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            Instantiate(dieGr, pos.position, Quaternion.identity);
            myBody.gravityScale = 1;
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), player, true);
            Destroy(gameObject, 2f);
        }
        if (target.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }

}
