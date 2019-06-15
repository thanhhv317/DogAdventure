using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWay : MonoBehaviour {

    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Ground")
        {
            Frog.facingRight = !Frog.facingRight;
        }
    }

}
