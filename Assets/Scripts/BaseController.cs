using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Bomb" || target.tag == "Bird") {
            Destroy(target.gameObject);
        }   
    }
}
