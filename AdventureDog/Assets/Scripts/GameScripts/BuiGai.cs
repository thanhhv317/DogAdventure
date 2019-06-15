using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuiGai : MonoBehaviour {

    Collider2D ground;

    // Use this for initialization
    void Start()
    {
        ground = GameObject.Find("Ground").GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), ground, true);
    }
}
