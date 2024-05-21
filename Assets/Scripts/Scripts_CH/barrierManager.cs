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
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Rain")){
            this.gameObject.SetActive(false);
        }
    }
}
