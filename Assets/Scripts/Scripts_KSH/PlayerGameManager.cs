using UnityEngine;

public class PlayerGameManager : MonoBehaviour
{
    private GameReferee referee;
    [SerializeField] GameObject barrier;
    [SerializeField] AudioSource audioSource;
    private void Start()
    {
        referee = FindObjectOfType<GameReferee>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rain"))
        {
            Debug.Log("부딪힘");
            referee.GameOver();
        }else if(collision.gameObject.CompareTag("Item")){
            barrier.SetActive(true);
            audioSource.Play();
        }
    }
}