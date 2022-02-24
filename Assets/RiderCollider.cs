using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiderCollider : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D riderFlip)
    {
        if(riderFlip.collider.tag == "FlipCollider")
        {
            Debug.Log("You flipped, restart the game!!");
        }
    }
}
