using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pow : MonoBehaviour {

    public float jump = 10f;
    public GameObject ef1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            PlayerMovement.player.myBody.velocity = new Vector2(
                PlayerMovement.player.myBody.velocity.x,
                jump
                );

            Instantiate(ef1, transform.position, Quaternion.identity);
        }
    }
}
