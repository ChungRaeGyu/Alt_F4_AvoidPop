using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
            bool localCheck = DataManager.instance.LoacalPlay;
            string whoWin=null;
            if (localCheck)
            {
                whoWin = gameObject.name == "Player1(Clone)" ?
                "2번플레이어가 승리했습니다." : "1번플레이어가 승리했습니다.";
            }
            referee.GameOver(whoWin);
        }else if(collision.gameObject.CompareTag("Item")){
            barrier.SetActive(true);
            audioSource.Play();
        }
    }
}