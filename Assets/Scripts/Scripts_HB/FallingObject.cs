using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    private ObjectPool objectPool;
    public float fallSpeed = 5f;

    void Start()
    {
        objectPool = FindObjectOfType<ObjectPool>();
    }

    private void Update()
    {
        // �Ʒ��� ��������
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Ground"))
        {
            // ������Ʈ�� Ǯ�� ��ȯ
            objectPool.ReturnObject(gameObject);
        }
    }
}
