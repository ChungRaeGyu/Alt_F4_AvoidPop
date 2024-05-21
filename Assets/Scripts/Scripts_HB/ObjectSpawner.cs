using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public ObjectPool objectPool;
    public float spawnInterval = 1f;
    public float spawnHeight = 10f;
    public float spawnRangeX = 5f;
    public float initialDelay = 3f; // �ʱ� ���� �ð�

    private float timeSinceLastSpawn;
    private bool spawningStarted = false; // ���� ���� ���� Ȯ��

    void Start()
    {
        // �ʱ� ���� �ð� ���� ���
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
        spawningStarted = true; // ���� ����
    }


    void SpawnObject()
    {
        GameObject obj = objectPool.GetObject();
        float spawnX = Random.Range(-spawnRangeX, spawnRangeX);
        obj.transform.position = new Vector2(spawnX, spawnHeight);
    }
}
