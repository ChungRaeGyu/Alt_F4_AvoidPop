using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public string userName;
    public int bestScore;
    public int characterNum;
    public int characterNum2;
    public int currentScore;
    public bool LoacalPlay;
    public List<Ranking> rankingList = new List<Ranking>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
