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
        // �Ʒ��� ��������
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Ground"))
        {
            // �ִϸ��̼� �� ��ƼŬ ����
            if (animator != null)
            {
                animator.SetTrigger("Disappear");
            }

            if (particleSystem != null)
            {
                particleSystem.Play();
            }

            // ���� �ð� �� ������Ʈ Ǯ�� ��ȯ
            StartCoroutine(ReturnToPoolAfterDelay(1f)); // 1�� �Ŀ� ��ȯ
        }
    }

    private IEnumerator ReturnToPoolAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // ��ƼŬ �ý����� �ִ� ��� ��ƼŬ�� ���� �� ��Ȱ��ȭ
        if (particleSystem != null)
        {
            particleSystem.Stop();
        }

        objectPool.ReturnObject(gameObject);
    }
}
