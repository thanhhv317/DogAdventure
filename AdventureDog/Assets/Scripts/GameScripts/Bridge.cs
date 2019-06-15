using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour {

    public Transform posBum;
    public GameObject bumbum;

    public Transform posBridgeInstantiate;
    public GameObject bridge;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bullet_Player")
        {
            Instantiate(bumbum, posBum.position, Quaternion.identity);
            StartCoroutine(delay(0));
            Destroy(gameObject,0.2f);
        }
    }

    IEnumerator delay(float time)
    {
        yield return new WaitForSeconds(time);
        Instantiate(bridge, posBridgeInstantiate.position, Quaternion.identity);

    }
}
