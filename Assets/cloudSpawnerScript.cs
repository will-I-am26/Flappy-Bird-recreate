using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject clouds;
    public float spawnRate = 2;
    private float timer = 0;
    private float heightOffset = 10;
    void Start()
    {
        spawnClouds();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnClouds();
            timer = 0;
        }
    }

    void spawnClouds()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(clouds, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
