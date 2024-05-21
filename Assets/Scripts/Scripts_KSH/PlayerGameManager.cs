using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGameManager : MonoBehaviour
{
    private GameReferee referee;
    [SerializeField] GameObject barrier;
    [SerializeField] AudioSource audioSource;
    [SerializeField] TMP_Text WinText;

    private void Awake(){
        if (DataManager.instance.LoacalPlay)
            WinText = GameObject.Find("WinText").GetComponent<TMP_Text>();
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
                whoWin = transform.name == "Player1(Clone)" ?
                "2번플레이어가 승리했습니다." : "1번플레이어가 승리했습니다.";
            }
            referee.GameOver(whoWin);
        }else if(collision.gameObject.CompareTag("Item")){
            barrier.SetActive(true);
            audioSource.Play();
        }
    }
}