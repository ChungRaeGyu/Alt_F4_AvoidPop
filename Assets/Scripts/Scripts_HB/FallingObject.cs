using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    private ObjectPool objectPool;
    public Animator animator;
    public ParticleSystem particleSystem;

    public float fallSpeed = 5f;

    void Start()
    {
        objectPool = FindObjectOfType<ObjectPool>();
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
            // 애니메이션 및 파티클 실행
            if (animator != null)
            {
                animator.SetTrigger("Disappear");
            }

            if (particleSystem != null)
            {
                particleSystem.Play();
            }

            // 일정 시간 후 오브젝트 풀로 반환
            StartCoroutine(ReturnToPoolAfterDelay(1f)); // 1초 후에 반환
        }
    }

    private IEnumerator ReturnToPoolAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // 파티클 시스템이 있는 경우 파티클이 끝난 후 비활성화
        if (particleSystem != null)
        {
            particleSystem.Stop();
        }

        objectPool.ReturnObject(gameObject);
    }
}
