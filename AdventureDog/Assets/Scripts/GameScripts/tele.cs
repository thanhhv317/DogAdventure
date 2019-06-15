using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tele : MonoBehaviour {

    public static tele tmp;

    public GameObject mancuoi;
    public bool check = false;


	// Use this for initialization
	void Awake () {
        if (tmp == null)
        {
            tmp = this;
        }
        else Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            mancuoi.SetActive(true);
            check = true;
            gameObject.SetActive(false);
        }
    }
}
