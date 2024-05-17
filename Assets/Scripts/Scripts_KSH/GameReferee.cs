using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameReferee : MonoBehaviour
{
    //[SerializeField] private GameObject player;
    //[SerializeField] private GameObject rain;
    [SerializeField] private Text currentScoreText;
    private PlayManager playManager;

    private int currentScore;
    private bool isEnd = false;

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
    }
}
