using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public ObjectPool objectPool;
    public float spawnInterval = 1f;
    public float spawnHeight = 5f;
    public float spawnRangeX = 2f;
    bool isFirst = true;
    public float gameTime = -3f;

    private float timeSinceLastSpawn;

    void Update()
    {
        if (isFirst == true)
        {
            spawnInterval = 3f;
            if (timeSinceLastSpawn >= spawnInterval)
            {
                SpawnObject();
                timeSinceLastSpawn = 0f;
                spawnInterval = 1f;
                isFirst = false;
            }
        }
        timeSinceLastSpawn += Time.deltaTime;
        gameTime += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval && isFirst == false)
        {
            SpawnObject();
            timeSinceLastSpawn = 0f;
        }
        if(gameTime > 30f && gameTime <= 60f)
        {
            spawnInterval = 0.75f;
        }
        else if(gameTime > 60f && gameTime <= 90f)
        {
            spawnInterval = 0.5f;
        }
        else if(gameTime > 90f)
        {
            spawnInterval = 0.25f;
        }
    }

    void SpawnObject()
    {
        GameObject obj = objectPool.GetObject();
        float spawnX = Random.Range(-spawnRangeX, spawnRangeX);
        obj.transform.position = new Vector2(spawnX, spawnHeight);
    }
}
