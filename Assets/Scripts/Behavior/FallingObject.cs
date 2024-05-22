using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    private ObjectPool objectPool;
    public Sprite[] sprites = new Sprite[4];
    public float fallSpeed = 5f;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        objectPool = FindObjectOfType<ObjectPool>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (this.CompareTag("Rain"))
        {
            spriteRenderer.sprite = sprites[Random.Range(0,sprites.Length)];
        }
        if (this.CompareTag("Item"))
        {
            fallSpeed = 3f;
        }
    }

    private void Update()
    {
        // 아래로 떨어지기
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Ground"))
        {
            // 오브젝트를 풀에 반환
            objectPool.ReturnObject(gameObject);
        }
    }
}
