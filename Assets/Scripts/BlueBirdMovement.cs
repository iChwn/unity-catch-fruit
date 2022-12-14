using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBirdMovement : MonoBehaviour
{
    private float freq = 6f;
    private float amp = .8f;
    private float cycleSpeed = 4f;
    private Vector3 pos;
    private Vector3 axis;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        axis = transform.up;
    }

    // Update is called once per frame
    void Update()
    {
        pos += Vector3.down * Time.deltaTime * cycleSpeed;
        transform.position = pos + axis * Mathf.Sin(Time.time * freq) * amp;
    }
}
