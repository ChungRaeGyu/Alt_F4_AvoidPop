using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject[] objectPrefabs; // ���� �������� ������ �迭
    public int initialPoolSize = 10;

    private List<GameObject> pool = new List<GameObject>();

    void Start()
    {
        // �ʱ� ������Ʈ Ǯ ����
        foreach (var prefab in objectPrefabs)
        {
            for (int i = 0; i < initialPoolSize; i++)
            {
                GameObject obj = Instantiate(prefab);
                obj.SetActive(false);
                pool.Add(obj);
            }
        }
    }

    public GameObject GetObject()
    {
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        // ��� ������Ʈ�� ��� ���� ���, ���� ���������� �� ������Ʈ ����
        GameObject newObj = Instantiate(objectPrefabs[Random.Range(0, objectPrefabs.Length)]);
        newObj.SetActive(false);
        pool.Add(newObj);
        return newObj;
    }

    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
    }
}
