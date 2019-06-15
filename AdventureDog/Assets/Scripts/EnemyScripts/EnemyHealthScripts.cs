using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScripts : MonoBehaviour {

    [SerializeField]
    private float maxHealth = 100f;

    [SerializeField]
    private float currentHealth;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
	}
    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag=="Bullet_Player")
        {
            currentHealth -= Stone.damage;
        }
    }

}
