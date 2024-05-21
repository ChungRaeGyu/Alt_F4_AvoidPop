using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject[] objectPrefabs; // 여러 프리팹을 저장할 배열
    public int initialPoolSize = 10;

    private List<GameObject> pool = new List<GameObject>();

    void Start()
    {
        // 초기 오브젝트 풀 생성
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

        // 모든 오브젝트가 사용 중일 경우, 랜덤 프리팹으로 새 오브젝트 생성
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
