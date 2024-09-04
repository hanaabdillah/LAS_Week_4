using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float spawnTime = 0;
    public float pipeOffset = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime < spawnRate)
        {
            spawnTime += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            spawnTime = 0;
        }
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - pipeOffset;
        float highestPoint = transform.position.y + pipeOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
