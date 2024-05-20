using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Rain")){
            this.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}
