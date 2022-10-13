using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSideCollider : MonoBehaviour
{
    public float bounce;

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.CompareTag("Bird")) {
            target.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
    }
}
