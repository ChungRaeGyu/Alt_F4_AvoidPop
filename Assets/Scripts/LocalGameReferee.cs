using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class LocalGameReferee : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;

    public GameObject resultPanel;
    public GameObject player1Win;
    public GameObject player2Win;

    private PlayManager playManager;

    private bool isEnd = false;
    public void GameOverLocal()
    {
        isEnd = true;
        Time.timeScale = 0.0f;
        resultPanel.SetActive(true);
        if (player1 == false)
        {
            player1Win.SetActive(true);
        }
        else if (player2 == false)
        {
            player2Win.SetActive(true);
        }
    }
}
