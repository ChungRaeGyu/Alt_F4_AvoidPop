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

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
