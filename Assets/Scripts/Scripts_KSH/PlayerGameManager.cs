using UnityEngine;

public class PlayerGameManager : MonoBehaviour
{
    private GameReferee referee;
    [SerializeField] GameObject barrier;
    private void Start()
    {
        referee = FindObjectOfType<GameReferee>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rain"))
        {
            Debug.Log("부딪힘");
            referee.GameOver();
        }else if(collision.gameObject.CompareTag("Item")){
            barrier.SetActive(true);
        }
    }
}