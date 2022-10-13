using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    private Rigidbody2D myBody;
    public float speed, xBound;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        // print(xAxis);
        
        myBody.velocity = Vector2.zero;
        if (Input.GetKey("a")) {
            myBody.velocity = Vector2.left * speed;
        }  
        if(Input.GetKey("d")) {
            myBody.velocity = Vector2.right * speed;
        }
        // if(xAxis > 0) {
        //     myBody.velocity = Vector2.right * speed;
        // } else if(xAxis < 0) {
        //     myBody.velocity = Vector2.left * speed;
        // }

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, -xBound, xBound),
            transform.position.y
        );
    }
}
