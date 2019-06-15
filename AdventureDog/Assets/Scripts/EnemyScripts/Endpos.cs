using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endpos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            Dragon.dragon.facingRight = !Dragon.dragon.facingRight;
        }
    }
}
