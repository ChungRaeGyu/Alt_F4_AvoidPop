using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameReferee : MonoBehaviour
{
    //[SerializeField] private GameObject player;
    //[SerializeField] private GameObject rain;
    [SerializeField] private TMP_Text currentScoreText;
    private PlayManager playManager;

    private int currentScore;
    private bool isEnd = false;
    //public TMP_Text nowScore;
    public GameObject resultPanel;

    private void Start()
    {
        playManager = FindObjectOfType<PlayManager>();
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
            if(currentScore > 0 )
            {
                currentScoreText.text = currentScore.ToString();
            }
        }
    }

    public void GameOver()
    {
        isEnd = true;
        Time.timeScale = 0.0f;
        resultPanel.SetActive(true);
    }
}
