using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    [SerializeField]
    private float maxHealth = 20;
    private float currentHealth;

    public Slider playerHealthSlider;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
        playerHealthSlider.maxValue = maxHealth;
        playerHealthSlider.value = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "BLet")
        {
            currentHealth -= 1; // by dragon
            playerHealthSlider.value = currentHealth;
            Debug.Log("health is " + currentHealth);
        }
    }

}
