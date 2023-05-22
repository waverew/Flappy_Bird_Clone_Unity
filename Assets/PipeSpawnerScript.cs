using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public float spawnRate;
    public GameObject pipe;
    private float timer = 0;
    private float heightDelt = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {   
        float minHeight = transform.position.y - heightDelt;
        float maxHeight = transform.position.y + heightDelt;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(minHeight, maxHeight), 0), transform.rotation);
    }
}
