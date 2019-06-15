using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    Rigidbody2D mybody;
    public Transform pos;
    public GameObject bumbum;

    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Dragon.dragon.transform.position.x<PlayerMovement.player.transform.position.x)
        {
            mybody.velocity = new Vector2(3, -3);
        }
        if (Dragon.dragon.transform.position.x > PlayerMovement.player.transform.position.x)
        {
            mybody.velocity = new Vector2(-3, -3);      
        }
        //Destroy(gameObject, 2f);
	}

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player" || target.tag=="Ground")
        {
            Instantiate(bumbum, pos.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
