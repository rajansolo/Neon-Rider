
using UnityEngine;

public class Destroy : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag == "Player")
        {
            Debug.Log("Restart");
        }
    }
}
