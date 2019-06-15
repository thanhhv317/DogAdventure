using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {

    public static Items item;
    public bool hasAStone;

	// Use this for initialization
	void Start () {
        hasAStone = false;
	}
    private void Awake()
    {
        if (item == null)
        {
            item = this;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            hasAStone = true;
            Destroy(gameObject);
        }
    }
}
