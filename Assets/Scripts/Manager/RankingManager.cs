using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RankingManager : MonoBehaviour
{
    [SerializeField] private GameObject rankingPanel;
    [SerializeField] private TMP_Text rankingText;
    //private List<Ranking> rankingList = new List<Ranking>();


    private void Start()
    {
        ShowRanking();
    }

    public void AddRanking(string name, int score)
    {
        DataManager.instance.rankingList.Add(new Ranking(name, score));
        SortRanking();
    }

    private void SortRanking()
    {
        DataManager.instance.rankingList.Sort((x,y) => y.score.CompareTo(x.score));
        ShowRanking();
    }

    private void ShowRanking()
    {
        if (DataManager.instance.rankingList.Count <= 0)
        {
            rankingText.text = "게임 기록이 없습니다.";
        }
        else
        {
            rankingText.text = "";
            for(int i = 0; i<Mathf.Min(5, DataManager.instance.rankingList.Count); i++)
            {
                rankingText.text += $"{i + 1}. {DataManager.instance.rankingList[i].name} - {DataManager.instance.rankingList[i].score}\n";
            }
        }
    }
}