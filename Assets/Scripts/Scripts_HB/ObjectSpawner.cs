using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public ObjectPool objectPool;
    public float spawnInterval = 1f;
    public float spawnHeight = 10f;
    public float spawnRangeX = 5f;

    private float timeSinceLastSpawn;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnObject();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnObject()
    {
        GameObject obj = objectPool.GetObject();
        float spawnX = Random.Range(-spawnRangeX, spawnRangeX);
        obj.transform.position = new Vector2(spawnX, spawnHeight);
    }
}
