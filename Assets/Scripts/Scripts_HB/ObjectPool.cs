using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject objectPrefab;
    [SerializeField] GameObject itemPrefab;
    public int initialPoolSize = 10;

    private Queue<GameObject> pool = new Queue<GameObject>();
    private Queue<GameObject> itemPool = new Queue<GameObject>();

    void Start()
    {
        // 초기 오브젝트 풀 생성
        for (int i = 0; i < initialPoolSize; i++)
        {
            InitializePool(objectPrefab,pool);
            InitializePool(itemPrefab, itemPool);
        }
    }

    private GameObject InitializePool(GameObject Prefab, Queue<GameObject> Pool)
    {
        GameObject obj = Instantiate(Prefab);
        obj.SetActive(false);
        Pool.Enqueue(obj);
        return obj;
    }

    public GameObject GetObject()
    {
        bool Persent = Random.Range(1, 6) % 5 == 1;
        if (Persent)
        {
            return GetPool(itemPool);
        }
        else
        {
            if (pool.Count > 0)
            {
                return GetPool(pool);
            }
            else
            {
                return InitializePool(objectPrefab, pool);
            }
        }

    }

    private GameObject GetPool(Queue<GameObject> Pool)
    {
        GameObject obj = Pool.Dequeue();
        obj.SetActive(true);
        return obj;
    }

    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
        if (obj.name== "TestObject(Clone)"){
            pool.Enqueue(obj);
            Debug.Log("돌아옴");
        }
            
        else
            itemPool.Enqueue(obj);
        
    }
}
