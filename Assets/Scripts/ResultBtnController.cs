using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultBtnController : MonoBehaviour
{
    public RankingManager rankingManager;

    private void Start()
    {
        rankingManager = GetComponent<RankingManager>();
    }
    public void Retry()
    {
        rankingManager.AddRanking(DataManager.instance.userName, DataManager.instance.currentScore);
        SceneManager.LoadScene("Main");
    }
    public void Retry2PMain(){
        SceneManager.LoadScene("2pMain");
    }
    public void ToMain()
    {
        rankingManager.AddRanking(DataManager.instance.userName, DataManager.instance.currentScore);
        SceneManager.LoadScene("Intro");
    }
}
