using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameReferee : MonoBehaviour
{
    // scorePanel
    [SerializeField] private TMP_Text currentScoreText;
    [SerializeField] private TMP_Text bestScoreText;
    [SerializeField] private Image bestRecord;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    
    private PlayManager playManager;

    // inGameInfo
    private int currentScore;
    private int bestScore;

    private bool isEnd = false;
    //public TMP_Text nowScore;

    // resultPanel
    public GameObject resultPanel;
    [SerializeField] private TMP_Text resultCurrentScoreText;
    [SerializeField] private TMP_Text resultBestScoreText;

    private void Start()
    {
        playManager = FindObjectOfType<PlayManager>();
        if(DataManager.instance != null)
        {
            bestScore = DataManager.instance.bestScore;
        }
        if (bestScore != 0)
        {
            bestScoreText.text = bestScore.ToString();
        }
        if(DataManager.instance.LoacalPlay){
            Instantiate(player1);
            Instantiate(player2);
        }else{
            Instantiate(player1);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnd)
        {
            Time.timeScale = 0f;
        }
        else
        {
            currentScore = 3 * (int)playManager.currentTime;
            if(currentScore > 0)
            {
                currentScoreText.text = currentScore.ToString();
                if (currentScore >= bestScore) 
                {
                    if(bestRecord.gameObject.active == false)
                    {
                        bestRecord.gameObject.SetActive(true);
                    }
                    bestScore = currentScore;
                    bestScoreText.text = currentScore.ToString();
                }
            }
        }
    }

    public void GameOver()
    {
        isEnd = true;
        Time.timeScale = 0.0f;
        resultPanel.SetActive(true);
        resultCurrentScoreText.text = currentScoreText.text;
        resultBestScoreText.text = bestScoreText.text;
        DataManager.instance.bestScore = bestScore;
        DataManager.instance.currentScore = currentScore;
    }
}
