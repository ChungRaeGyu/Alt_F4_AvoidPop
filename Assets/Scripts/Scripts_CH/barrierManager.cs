using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierManager : MonoBehaviour
{
    private ObjectPool objectPool;
    void Start()
    {
        objectPool =FindObjectOfType<ObjectPool>();
        this.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Rain"))
        {
            this.gameObject.SetActive(false);
            objectPool.ReturnObject(other.gameObject);
        }
    }
}
