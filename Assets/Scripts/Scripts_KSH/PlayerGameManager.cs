using UnityEngine;

public class PlayerGameManager : MonoBehaviour
{
    private GameReferee referee;

    private void Start()
    {
        referee = FindObjectOfType<GameReferee>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rain"))
        {
            referee.GameOver();
        }
    }
}