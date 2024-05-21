using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public ObjectPool objectPool;
    public float spawnInterval = 1f;
    public float spawnHeight = 10f;
    public float spawnRangeX = 5f;
    public float initialDelay = 3f; // 초기 지연 시간

    private float timeSinceLastSpawn;
    private bool spawningStarted = false; // 스폰 시작 여부 확인

    void Start()
    {
        // 초기 지연 시간 동안 대기
        Invoke("StartSpawning", initialDelay);
    }


    void Update()
    {
        if (spawningStarted)
        {
            timeSinceLastSpawn += Time.deltaTime;

            if (timeSinceLastSpawn >= spawnInterval)
            {
                SpawnObject();
                timeSinceLastSpawn = 0f;
            }
        }
    }

    void StartSpawning()
    {
        spawningStarted = true; // 스폰 시작
    }


    void SpawnObject()
    {
        GameObject obj = objectPool.GetObject();
        float spawnX = Random.Range(-spawnRangeX, spawnRangeX);
        obj.transform.position = new Vector2(spawnX, spawnHeight);
    }
}
