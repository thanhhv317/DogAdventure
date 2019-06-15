using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Vector3 target;
    public float speed;
    Rigidbody2D rb;
    public GameObject efc;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        target = PlayerMovement.player.transform.position;

  	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((transform.position - target) * speed * Time.deltaTime*-1);
        Destroy(gameObject, 3f);
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Instantiate(efc, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
