using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] birds;
    public GameObject bomb;
    public float xBounds, yBound;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject() {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomBird = Random.Range(0, birds.Length);
        if(Random.value <= .6f) {
            Instantiate(
                birds[randomBird],
                new Vector2(Random.Range(-xBounds, xBounds), yBound),
                Quaternion.identity
            );
        } else {
            Instantiate(
                bomb,
                new Vector2(Random.Range(-xBounds, xBounds), yBound),
                Quaternion.identity
            );
        }

        StartCoroutine(SpawnRandomGameObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
